namespace Methods;
class Program
{
    static void Main(String[] args)
    {
        #region VoidMethods

        void CustomerList()
        {
            Console.WriteLine("Ahmet Kamaç");
            Console.WriteLine("Marco Asensio");
            Console.WriteLine("Ngolo Kante");
            Console.WriteLine("Mason Greenwood");
        }

        CustomerList();
        Console.WriteLine();

        void Sum()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            Console.WriteLine(c);
        }

        Sum();

        #endregion

        #region VoidMethods(String)
        Console.WriteLine();

        void WriteMethod(string customerName)
        {
            Console.WriteLine(customerName);
        }

        WriteMethod("Ahmet");
        Console.WriteLine();
        
        void CustomerCard(string name, string surName)
        {
            Console.WriteLine(name + " " +surName);
        }

        CustomerCard("Ahmet", "Kamaç");
        CustomerCard("Kadir", "Kamaç");

        #endregion

        #region VoidMethods(Int)
        Console.WriteLine();

        void Sum1(int number1, int number2, int number3)
        {
            int result = number1 + number2 + number3;
            Console.WriteLine(result);
        }

        Sum1(10,20,30);

        #endregion

        #region ValueReturningMethods
        Console.WriteLine();

        string StudentCard()
        {
           string name = "Sudenur";
           string surName = "Ak";
           return name + " " + surName;
        }

        Console.WriteLine(StudentCard());

        #endregion
        
        #region ValueReturningMethodsWithParameters(String)
        Console.WriteLine();

        string CountryCard(string countryName, string capital, string flagColor)
        {
            string cardInfo = "Country: " + countryName + " - Capital: " + capital + " - Flag Color: " + flagColor;
            return cardInfo;
        }
        
        string x,y,z;
        Console.Write("Enter the country name: ");
        x = Console.ReadLine();
        Console.Write("Enter the capital: ");
        y = Console.ReadLine();
        Console.Write("Enter the flag color: ");
        z = Console.ReadLine();

        Console.WriteLine(CountryCard(x,y,z));
        Console.WriteLine(CountryCard("Turkey","Ankara","Red-White")); // You can also use it like this

        #endregion

        #region ValueReturningMethodsWithParameters(Integer)
        Console.WriteLine();

        int Sum2(int a, int b, int c)
        {
            int result = a + b + c;
            Console.Write("The result is: ");
            return result;
        }
        
        int num1, num2, num3;
        Console.Write("Enter a number 1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a number 2: ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter a number 3: ");
        num3 = int.Parse(Console.ReadLine());

        Console.WriteLine(Sum2(num1, num2, num3));

        #endregion

        #region Example
        Console.WriteLine();

        string ExamResult(string student,int exam1, int exam2, int exam3)
        {
            int result = (exam1 + exam2 + exam3) / 3;
            
            if (result >= 50)
            {
                return student + ", successfully passed the lesson. Average: " + result;
            }
            else 
            {
                return student + ", failed the lesson. Average: " + result;
            }
        }
        Console.WriteLine(ExamResult("Ahmet", 100, 90, 75));
        
        #endregion
        
        Console.Read();
    }
}