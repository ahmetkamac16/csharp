namespace Collections;
class Program
{
    static void Main(String[] args)
    {
        #region List<T>

        List<string> cities = new List<string>();
        cities.Add("Bursa");  // Adds an element
        cities.Add("Paris");
        cities.Add("London");
        cities.Remove("Paris");  // Remove an element

        Console.WriteLine(cities[0]); // Bursa
        Console.WriteLine(cities.Count); // 2

        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }

        Console.WriteLine("---------------------------------------------------------------");

        List<int> numberList = new List<int>();
        numberList.Add(1);
        numberList.Add(2);
        numberList.Add(3);
        numberList.Add(4);
        numberList.Remove(4); 

        Console.WriteLine($"The element at index 2: {numberList[2]}");
        Console.WriteLine($"Number of elements in the list: {numberList.Count}"); 

        Console.WriteLine();
        Console.WriteLine("The elements in the list: ");

        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }

        #endregion

        #region Dictionary<TKey,TValue>

        Console.WriteLine();

        Dictionary<string, int> prices = new Dictionary<string, int>();
        prices.Add("Burger",9);
        prices.Add("Pizza",13);
        prices["Pasta"] = 2;     // You can also add it like this.
        prices.Remove("Pizza");

        foreach (var item in prices)
        {
            Console.WriteLine(item.Key + ": $" + item.Value);
        }

        #endregion

        #region Queue<T>

        Console.WriteLine();

        // FIFO – First In, First Out
        Queue<string> customers = new Queue<string>();
        customers.Enqueue("Batalla");  // Adds to the end of the tail
        customers.Enqueue("Volkan");
        customers.Enqueue("Carson");

        Console.WriteLine(customers.Dequeue());  // Batalla
        Console.WriteLine(customers.Peek()); // Volkan (Does not remove)
        Console.WriteLine(customers.Count); // 2

        #endregion

        #region Stack<T>
        
        Console.WriteLine();

        // LIFO – Last In, First Out
        Stack<string> pages = new Stack<string>();
        pages.Push("Home");  // adds to the very top
        pages.Push("Products");
        pages.Push("Communication");

        Console.WriteLine(pages.Pop()); // Communication
        Console.WriteLine(pages.Peek()); // Products (Does not remove)
        Console.WriteLine(pages.Count()); // 2

        #endregion

        #region HashSet<T>

        Console.WriteLine();

        // Stores unique elements.
        HashSet<int> numbers = new HashSet<int>();

        numbers.Add(16);
        numbers.Add(23);
        numbers.Add(16);  // Already exists, cannot be added.

        Console.WriteLine(numbers.Count); // 2
        Console.WriteLine(numbers.Contains(16)); // True

        #endregion

    }
}