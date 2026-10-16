namespace Classes_and_Objects;
class Program
{
    static void Main(String[] args)
    {
        #region ClassAndObjects
        // A class is a blueprint. An object is an instance created from that class with 'new'.
        
        Car car1 = new Car();
        car1.Brand = "BMW";
        car1.Year = 2020;

        Car car2 = new Car();
        car2.Brand = "Porsche";
        car2.Year = 2024;

        Console.WriteLine(car1.Brand + "-" + car1.Year);
        Console.WriteLine(car2.Brand + "-" + car2.Year);

        #endregion

        #region Methods

        // Methods are the behaviors of an object.

        Console.WriteLine();
        car1.ShowInfo();

        #endregion

        #region Constructors

        // A constructor runs automatically when the object is created.

        Console.WriteLine();
        Student student1 = new Student("Ali", 85);
        Console.WriteLine(student1.Name + " - " + student1.Grade); // Ali - 85

        #endregion

        #region Properties

        // A property controls access to a private field with get and set.

        Console.WriteLine();
        Product product1 = new Product();
        product1.Price = 100;
        product1.Price = -20;                // Rejected by 'set'.
        Console.WriteLine(product1.Price);   // 100

        #endregion

        #region ReferenceType

        // Classes are reference types. Both variables point to the same object.

        Console.WriteLine();
        Car car3 = car1;
        car3.Brand = "Honda";
        Console.WriteLine(car1.Brand); // Honda

        #endregion

        Console.Read();
    }
}

class Car
{
    public string Brand;  
    public int Year;      

    public void ShowInfo()  
    {
        Console.WriteLine("Brand: " + Brand + ", Year: " + Year);
    }
}

class Student
{
    public string Name;
    public int Grade;

    public Student(string name, int grade)  // Constructor: same name as the class, no return type.
    {
        Name = name;
        Grade = grade;
    }
}

class Product
{
    private double price;  // Cannot be accessed from outside the class.

    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)  // 'value' is the assigned number.
                price = value;
        }
    }
}