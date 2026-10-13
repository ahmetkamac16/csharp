namespace Conditional_Statements;

class Program
{
    static void Main(String[] args)
    {
    
        #region IfElse

        Console.WriteLine("Please enter your password: ");
        string password = Console.ReadLine();
        if (password == "abc")
        {
            Console.WriteLine("The password is correct");
        }
        else
        {
            Console.WriteLine("The password is incorrect");
        }

        Console.WriteLine();

        int exam1, exam2, exam3, average;
        string result = "Error";

        Console.Write("Exam1: ");
        exam1 = int.Parse(Console.ReadLine());
        Console.Write("Exam2 ");
        exam2 = int.Parse(Console.ReadLine());
        Console.Write("Exam3: ");
        exam3 = int.Parse(Console.ReadLine());

        average = (exam1 + exam2 + exam3) / 3;
        Console.Write("The average of the exams: "+ average);

        if(average > 0 && average <= 50 )
        {
            result = " The result is bad";
        }
        else if (average>50 && average <= 70)
        {
            result = " The result is medium";
        }
        else if (average>70 && average <= 84)
        {
            result = " The result is good";
        }
        else if (average > 84)
        {
            result = " The result is very good";
        }

        Console.WriteLine(result);

        #endregion

        #region ModOperations
            
            Console.WriteLine();

            int a = 26;
            int b = a % 5; 
            Console.WriteLine(b); // the remainder of 'a' divided by 5

        #endregion
        
        #region CharOperations

        char team;
        Console.Write("Please enter the team symbol: ");
        team = char.Parse(Console.ReadLine());

        if (team == 'f' || team == 'F')
        {
            Console.Write("Fenerbahçe");
        }
        else if (team == 'b' || team == 'B')
        {
            Console.Write("Bursaspor");
        }
        else if (team == 'g' || team == 'G')
        {
            Console.Write("Galatasaray");
        }

        #endregion

        #region SwitchCaseStructures

        Console.WriteLine();
        Console.WriteLine("Please enter the month: ");
        int monthNumber = int.Parse(Console.ReadLine());

        switch (monthNumber)
        {
            case 1: Console.Write("January"); break;
            case 2: Console.Write("February"); break;
            case 3: Console.Write("March"); break;
            case 4: Console.Write("April"); break;
            case 5: Console.Write("May"); break;
            case 6: Console.Write("June"); break;
            case 7: Console.Write("July"); break;
            case 8: Console.Write("August"); break;
            case 9: Console.Write("September"); break;
            case 10: Console.Write("October"); break;
            case 11: Console.Write("November"); break;
            case 12: Console.Write("December"); break;
            default: Console.Write("Incorrect data entry"); break;
        }


        #endregion
        
        Console.Read();

    }        
}