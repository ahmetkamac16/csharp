namespace Arrays;
class Program
{
    static void Main(String[] args)
    {
        #region BasicArrayExample
        
        string[] colors = new string[4];
        colors[0] = "Red";
        colors[1] = "Green";
        colors[2] = "Blue";
        colors[3] = "White";

        Console.WriteLine(colors[2]);

        Console.WriteLine("------------------------------------------------------");

        string[] cities = {"Prag", "Roma", "Berlin", "Bursa", "Paris"};
        Console.WriteLine(cities[3]);
        
        #endregion
        
        #region ListingTheDataInTheArray

        Console.WriteLine();

        string[] colorsArray = {"yellow", "red", "white", "blue", "green", "orange", "pink"};

        for (int i = 0; i < colorsArray.Length; i++)
        {
            Console.WriteLine(colorsArray[i]);
        }

        Console.WriteLine();

        int[] myArray = {47, 85, 42, 64,100};
        int maxNumber = myArray[0];

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] > maxNumber)
            {
                maxNumber = myArray[i];
            }
        }
        Console.WriteLine(maxNumber);

        #endregion
        
        #region ArrayMethods
        
        Console.ReadLine();

        string[] customers = {"Michael", "John", "Peter", "Joshua"};
        int index = Array.IndexOf(customers, "John");
        Console.WriteLine(index);  // John
        
        Console.WriteLine();

        int[] numbers = { 47, 89, 150, 56, 750};
        Console.WriteLine("The largest number in the array: " + numbers.Max() + " The smallest number in the array: " + numbers.Min());

        #endregion
        
        #region GetValueFromUser
        
        Console.WriteLine();

        string[] cities1 = new string[5];

        for (int i=0;i<cities1.Length; i++)
        {
            Console.Write($"Please {i + 1}. enter the city: ");
            cities1[i] = Console.ReadLine();
        }

        Console.WriteLine();
        
        for(int i=0;i < cities1.Length; i++)
        {
            Console.WriteLine(cities1[i]);
        }

        Console.WriteLine();

        int[] data = {10, 20, 30, 40, 50};
        int sum = 0;

        for (int i=0; i < data.Length; i++)
        {
            sum += data[i];
        }

        Console.WriteLine(sum);

        Console.WriteLine();
        string[] cities2 = {"milano", "roma", "ankara", "berlin"};

        foreach (string city in cities2)
        {
            Console.WriteLine(city);
        }


        #endregion
        Console.Read();

    }
}