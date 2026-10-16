namespace Object_Oriented_Programming;
class Program
{
    static void Main(string[] args)
    {
        #region Encapsulation
        
        BankAccount account = new BankAccount();
        account.Deposit(100);
        account.Withdraw(20);
        account.Withdraw(100);

        Console.WriteLine(account.Balance);

        #endregion

        #region Inheritance 
        Console.WriteLine();

        Dog rex = new Dog();
        rex.Name = "Rex";
        rex.Eat();
        rex.Bark();

        #endregion

        #region Polymorphism
        Console.WriteLine();

        Animal animal1 = new Dog();
        Animal animal2 = new Cat();
        Animal animal3 = new Fish();

        animal1.Name = "Alex";
        animal2.Name = "Bofi";
        animal3.Name = "Nemo";

        animal1.MakeSound();
        animal2.MakeSound();
        animal3.MakeSound();

        #endregion

        #region Abstraction
        Console.WriteLine();

        Shape shape1 = new Circle(2);
        Shape shape2 = new Square(3);

        Console.WriteLine(shape1.Area());
        Console.WriteLine(shape2.Area());

        #endregion

        #region Interface 
        Console.WriteLine();

        Duck duck = new Duck();

        duck.Swim();
        duck.Fly();

        IFlyable a = new Duck();
        a.Fly();

        #endregion
    
        Console.Read();
    }
}

class BankAccount
{

    private double balance;

    public double Balance
    {
        get { return balance; }
    }


    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance = balance - amount;
        }
        else
        {
            Console.WriteLine("Not enough balance!");
        }
    }

}

class Animal
{
    public string Name;

    public void Eat()
    {
        Console.WriteLine(Name + " is eating.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine(Name + ": ...");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine(Name + " is barking.");
    }

    public override void MakeSound()
    {
        Console.WriteLine(Name + ": Woof!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine(Name + ": Meow!");
    }
}

class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine(Name + " is swimming");
    }
}

abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return 3.14 * radius * radius;
    }
}

class Square : Shape
{
    private double side;
    
    public Square(double side) 
    {
        this.side = side;
    }

    public override double Area()
    {
        return side * side;
    }

}

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

class Duck : IFlyable , ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Duck is flying.");
    }
    public void Swim()
    {
        Console.WriteLine("Duck is swimming.");
    }
}