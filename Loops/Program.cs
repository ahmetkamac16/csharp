namespace Loops;
class Program
{
    static void Main(String[] args)
    {   
        #region ForLoop

        // For (x;y;z)
        // x: start
        // y: finish
        // z: increase/decrease

        Console.Write("Enter how many times to print:");
        int finishValue = int.Parse(Console.ReadLine());
        for (int i = 1; i<= finishValue; i++)
        {
            Console.WriteLine("Hello World");
        }

        Console.Write("Up to which number do you want to see the even numbers?");
        int value = int.Parse(Console.ReadLine());

        for (int a = 1; a <= value; a++)
        {
            if(a % 2 == 0)
            {
                Console.Write(a + "-");
            }
        }

        #endregion  

        #region WhileLoop
        
        Console.WriteLine();

        int c = 1;
        while (c <= 10)
        {
            Console.WriteLine("Hello Loops");
            c++;
        }

        #endregion

        #region ForeachLoop

        Console.WriteLine();
        string[] cities = {"milano", "roma", "ankara", "berlin"};

        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }

        #endregion

        #region DoWhile

        Console.WriteLine();

        int x = 1;

        do
        {
            Console.WriteLine(x);
            x++;
        }
        while (x <= 5);

        #endregion
        
        Console.Read();
    }
}