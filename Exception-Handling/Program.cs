namespace ExceptionHandling;

class Program
{
    static void Main(String[] args)
    {
        #region TryCatch

        try
        {
            int a = 10;
            int b = 0;
            Console.WriteLine(a / b); // DivideByZeroException
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        #endregion

        #region MultipleCatch
        Console.WriteLine();

        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("100 / " + number + " = " + (100 / number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero is not allowed!");
        }
        catch (Exception ex) // The general Exception must always be the LAST catch
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("The finally block always runs.");
        }

        #endregion

        #region Throw
        Console.WriteLine();

        void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("People under 18 cannot register.");
            }
            Console.WriteLine("Registration successful.");
        }

        try
        {
            CheckAge(15);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        #endregion

        #region CustomException
        Console.WriteLine();

        void Withdraw(int balance, int amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException();
            }
            Console.WriteLine("Remaining balance: " + (balance - amount));
        }

        try
        {
            Withdraw(500, 1000);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }

        #endregion

        Console.Read();
    }
}

// Custom exception classes go OUTSIDE the Program class
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException() : base("Insufficient balance!")
    {
    }
}