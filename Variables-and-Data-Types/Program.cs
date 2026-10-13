namespace Variables_and_Data_Types;
class Program 
{
    static void Main(string[] args)
    {
        
        #region PrintCommands
        // Case 1: Write() does not add a new line, so "Hi" is printed right next to it -> "Hello WorldHi"
        Console.Write("Hello World");
        Console.WriteLine("Hi");
        Console.WriteLine();

        // Case 2: WriteLine() adds a new line after "Hello World", so "Hi" is printed on the next line
        Console.WriteLine("Hello World");
        Console.Write("Hi");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("***** Food Categories *****");
        Console.WriteLine("1-Soups");
        Console.WriteLine("2-Main Foods");
        Console.WriteLine("3-Cold Starters");
        Console.WriteLine("4-Salads");
        Console.WriteLine("5-Desserts");
        Console.WriteLine("6-Beverages");

        #endregion

        #region StringVariables

        string customerName, customerSurname, customerPhone, customerEmail, district, city;

        customerName = "Michael";
        customerSurname = "Cherki";
        customerPhone = "+33 6 39 98 12 34";
        customerEmail = "michael.cherki@example.com";
        district = "Marais";
        city = "Paris";

        Console.WriteLine("**** Reservation Card ****");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Customer: "+ customerName + " " + customerSurname);
        Console.WriteLine("Communicaion: " + customerPhone);
        Console.WriteLine("Email Address: " + customerEmail);
        Console.WriteLine("Address: " + district + "/" + city);
        Console.WriteLine("--------------------------------------------------");

        customerName = "Ryan";
        customerSurname = "Olise";
        customerPhone = "+33 5 23 12 34 56";
        customerEmail = "ryan.olise@example.com";
        district = "Bastille";
        city = "Paris";

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Customer: "+ customerName + " " + customerSurname);
        Console.WriteLine("Communication: " + customerPhone);
        Console.WriteLine("Email Address: " + customerEmail);
        Console.WriteLine("Address: " + district + "/" + city);
        Console.WriteLine("--------------------------------------------------");

        #endregion

        #region IntVariables
        
        // int number = 12; // integer type veriable
        // Console.WriteLine(number);

        int burgerPrice = 9;
        int cokePrice = 3;
        int waterPrice = 1;
        int friesPrice = 4;
        int pizzaPrice = 11;
        int lemonadePrice = 2;

        Console.WriteLine("**** Restaurant Menu Price ****");
        Console.WriteLine("-Burger: $" + burgerPrice);
        Console.WriteLine("-Coke: $" + cokePrice);
        Console.WriteLine("-Water: $" + waterPrice);
        Console.WriteLine("-Fries: $" + friesPrice);
        Console.WriteLine("-Pizza: $" + pizzaPrice);
        Console.WriteLine("-Lemonade: $" + lemonadePrice);


        Console.WriteLine();
        int burgerCount = 3;
        int cokeCount = 3;
        int waterCount = 3;
        int friesCount = 1;
        int pizzaCount = 0;
        int lemonadeCount = 0;

        int totalBurgerPrice = burgerCount*burgerPrice;
        int totalCokePrice = cokeCount*cokePrice;
        int totalWaterPrice = waterCount*waterPrice;
        int totalFriesPrice = friesCount*friesPrice;
        int totalPizzaPrice = pizzaCount*pizzaPrice;
        int totalLemonadePrice = lemonadeCount*lemonadePrice;
        int totalPrice = totalBurgerPrice+totalCokePrice+totalWaterPrice+totalFriesPrice+totalPizzaPrice+totalLemonadePrice;

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Total Burger Price: $" + totalBurgerPrice);
        Console.WriteLine("Total Coke Price: $"+ totalCokePrice);
        Console.WriteLine("Total Water Price: $"+ totalWaterPrice);
        Console.WriteLine("Total Fries Price: $"+ totalFriesPrice);
        Console.WriteLine("Total Pizza Price: $"+ totalPizzaPrice);
        Console.WriteLine("Total Lemonade Price: $"+ totalLemonadePrice);
        Console.WriteLine();
        Console.WriteLine("Total Price: $"+totalPrice);
        Console.WriteLine("------------------------------------------------");
        
        #endregion

        #region DoubleVariables

        // double pi = 3.14; //double type veriable
        // Console.WriteLine(pi);

        Console.WriteLine("***** Price List *****");
        
        double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

        applePrice = 2.50;
        orangePrice = 3.20;
        strawberryPrice = 6.75;
        potatoPrice = 1.80;
        tomatoPrice = 3.40;

        Console.WriteLine("-Unit Price of Apples: $" + applePrice);
        Console.WriteLine("-Unit Price of Oranges: $" + orangePrice);
        Console.WriteLine("-Unit Price of Strawberries: $" + strawberryPrice);
        Console.WriteLine("-Unit Price of Potatoes: $" + potatoPrice);
        Console.WriteLine("-Unit Price of Tomatoes: $" + tomatoPrice);

        Console.WriteLine();
        Console.WriteLine();

        double appleGrams, orangeGrams, strawberryGrams, potatoGrams, tomatoGrams;

        appleGrams = 1.234;
        orangeGrams = 2.650;
        strawberryGrams = 0.750;
        potatoGrams = 4.859;
        tomatoGrams = 3.123;
        
        double appleTotalPrice = appleGrams * applePrice;
        double orangeTotalPrice = orangeGrams * orangePrice;
        double strawberryTotalPrice = strawberryGrams * strawberryPrice;
        double potatoTotalPrice = potatoGrams * potatoPrice;
        double tomatoTotalPrice = tomatoGrams * tomatoPrice;

        Console.WriteLine("Purchased Product: Apple " + " - Unit Price: " + applePrice + " - Weight: " +appleGrams +" - Total Price: $" + appleTotalPrice);
        Console.WriteLine("Purchased Product: Orange " + " - Unit Price: " + orangePrice + " - Weight: " + orangeGrams +" - Total Price: $" + orangeTotalPrice);
        Console.WriteLine("Purchased Product: Strawberry " + " - Unit Price: " + strawberryPrice + " - Weight: " + strawberryGrams + " - Total Price: $" + strawberryTotalPrice);
        Console.WriteLine("Purchased Product: Potato " + " - Unit Price: " + potatoPrice + " - Weight: " + potatoGrams + " - Total Price: $" + potatoTotalPrice);
        Console.WriteLine("Purchased Product: Tomato " + " - Unit Price: " + tomatoPrice + " - Weight: " + tomatoGrams + " - Total Price: $" + tomatoTotalPrice);

        double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Shopping Total Price: $" + shoppingTotalPrice);
        
        #endregion

        #region CharVariables

        char symbol = 'a';
        Console.WriteLine(symbol);

        #endregion

        #region BooleanVariables

        bool isStudent = true;
        bool isWorking = false;
        bool hasDriverLicense = true;
        bool isActive = 10 < 15;

        Console.WriteLine("Is Student: " + isStudent);
        Console.WriteLine("Is Working: " + isWorking);
        Console.WriteLine("Has Driver License: " + hasDriverLicense);
        Console.WriteLine("Is Active: " + isActive);

        #endregion

        #region DateTimeVariables

        DateTime date = DateTime.Now; // Current date and time
        DateTime today = DateTime.Today; // Current date

        string formattedDate = DateTime.Now.ToString("dd/MM/yyyy"); // Date format
        string formattedTime = DateTime.Now.ToString("HH:mm:ss"); // Time format

        Console.WriteLine("Current Date: " + date);
        Console.WriteLine("Today: " + today);
        Console.WriteLine("Formatted Date: " + formattedDate);
        Console.WriteLine("Formatted Time: " + formattedTime);

        #endregion

        #region ConstantVariables

        const double PI = 3.14159;      // Immutable Constant
        const int DAYS_IN_WEEK = 7;     // Immutable Constant
        const int MONTHS_IN_YEAR = 12;  // Immutable Constant

        Console.WriteLine("PI: " + PI);
        Console.WriteLine("Days In Week: " + DAYS_IN_WEEK);
        Console.WriteLine("Months In Year: " + MONTHS_IN_YEAR);

        #endregion

        #region VarVariables

        // `var` allows the compiler to determine the variable's data type from the value assigned during initialization.

        var studentName = "Ahmet";  // string
        var studentAge = 21;        // int
        var studentGpa = 3.80;      // double
        var isGraduated = false;    // bool
        var currentDate = DateTime.Now; // DateTime

        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Student Age: " + studentAge);
        Console.WriteLine("Student GPA: " + studentGpa);
        Console.WriteLine("Is Graduated: " + isGraduated);
        Console.WriteLine("Current Date: " + currentDate);

        #endregion

        #region IntDataTypes

        byte a = 255;                  // 1 byte
        short b = 32767;               // 2 byte
        int c = 2147483647;           // 4 byte
        long d = 9223372036854775807; // 8 byte    

        #endregion

        Console.Read();
        
    }
}

