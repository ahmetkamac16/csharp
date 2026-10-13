namespace Input_and_Type_Conversions;
class Program
{
    static void Main(string[] args)
    {

        #region StringUserInput

        Console.WriteLine("**** CSHARP AIRLINES ****");
        
        string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

        Console.Write("Passenger Name: ");
        passengerName = Console.ReadLine(); // Passenger name input received.

        Console.Write("Passenger Surname: ");
        passengerSurname = Console.ReadLine(); // Passenger Surname input received.
        
        Console.Write("District Information: ");
        passengerDistrict = Console.ReadLine(); // Passenger District input received.

        Console.Write("City Information: ");
        passengerCity = Console.ReadLine(); // Passenger City input received.

        Console.Write("Passenger Age: ");
        passengerAge = Console.ReadLine(); // Passenger Age input received.

        Console.Write("Passenger Identification Number: ");
        passengerIdentityNumber = Console.ReadLine(); // Passenger Identification Number input received.

        Console.WriteLine();

        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("Passenger Identification Number: " + passengerIdentityNumber + " - Passenger Name Surname: " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge );

        #endregion

        #region IntegerUserInput 
        
        int shoePrice, computerPrice, chairPrice, tvPrice;

        shoePrice = 40;
        computerPrice = 1000;
        chairPrice = 60;
        tvPrice = 750;

        int shoeCount, computerCount, chairCount, tvCount;

        Console.WriteLine();

        Console.Write("Please enter the number of shoes you purchased: ");  // Converts the string input from the keyboard to an integer.
        shoeCount = int.Parse(Console.ReadLine());  // Console.ReadLine() always returns a string, so int.Parse() converts it to an integer

        Console.Write("Please enter the number of computer you purchased: ");
        computerCount = int.Parse(Console.ReadLine());

        Console.Write("Please enter the number of chair you purchased: ");
        chairCount = int.Parse(Console.ReadLine());
        
        Console.Write("Please enter the number of tv you purchased: ");
        tvCount = int.Parse(Console.ReadLine());

        int totalPrice = shoeCount*shoePrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

        Console.WriteLine();
        Console.WriteLine("The total amount you need to pay: $" + totalPrice);
        
        #endregion

        #region DoubleUserInput

        double exam1, exam2, exam3, result;

        Console.WriteLine();

        Console.Write("Enter the first exam grade: ");
        exam1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second exam grade: ");
        exam2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the third exam grade: ");
        exam3 = double.Parse(Console.ReadLine());

        result = (exam1 + exam2 + exam3) / 3;

        Console.WriteLine();
        Console.WriteLine("Your exam average: " + result);

        #endregion

        #region CharUserInput

        char gender;
        Console.WriteLine();
        Console.WriteLine("Please select a gender: ");
        gender = char.Parse(Console.ReadLine()); // You only need to enter one character.

        Console.WriteLine("The gender you selected: " + gender);

        #endregion

        #region ImplicitConversion

        // It only happens when switching from a smaller type to a larger type.

        Console.WriteLine();
        int implicitNumber = 100;
        double implicitResult = implicitNumber;   // int automatically converts to double.
        Console.WriteLine(implicitResult); // 100


        #endregion

        #region ExplicitConversion

        // It only happens when switching from a larger type to a smaller type.

        Console.WriteLine();

        double price = 9.99;
        int roundedPrice = (int)price;   // double is converted to int

        Console.WriteLine(roundedPrice); // 9  (the decimal part is lost, no rounding occurs.)

        #endregion
    
        #region ConvertMethods

        Console.WriteLine();

        string a = "150";
        int b = Convert.ToInt32(a);
        Console.WriteLine(b);
        
        #endregion

        #region TryParseMethods

        string numberText = "250";
        int parsedNumber;

        bool isSuccess = int.TryParse(numberText, out parsedNumber);

        Console.WriteLine("Conversion Successful: " + isSuccess);
        Console.WriteLine("Converted Number: " + parsedNumber);

        #endregion

        Console.Read();
    }
    
}






