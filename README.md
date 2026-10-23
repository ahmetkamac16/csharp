# C# CSharp

This repository documents my hands-on C# CSharp, from language fundamentals and object-oriented programming to database access and layered application design. Independent console exercises introduce each topic, while Windows Forms applications bring together Entity Framework, LINQ, CRUD operations, and dependency injection.

The goal is to understand how C# features work and how they fit together in an application. The database examples were developed against local SQL Server databases.

## Introduction: C# Operators

Operators are practiced throughout the examples; there is no separate operators project.

| Group | Operators used | Examples |
| --- | --- | --- |
| Arithmetic | `+`, `-`, `*`, `/`, `%` | Shopping totals, withdrawals, exam averages, and even-number checks. |
| Assignment | `=`, `+=` | Assigning values and accumulating array elements or balances. |
| Comparison | `==`, `!=`, `<`, `>`, `<=`, `>=` | Password checks, grade ranges, loop conditions, and customer validation. |
| Logical | `&&`, `\|\|` | Combining conditions and accepting alternative team symbols. |
| Increment | `++` | Advancing loop counters. |
| String concatenation | `+` | Combining names, labels, and values for display. |

## Fundamentals

Each directory below contains an independent console project. Examples are organized into regions in `Program.cs`.

### 1. Variables and Data Types

[`Variables-and-Data-Types/`](Variables-and-Data-Types/) covers console output, strings, numeric types, characters, booleans, `DateTime`, constants, and `var`. Reservation cards, restaurant bills, and shopping calculations demonstrate their use.

### 2. Input and Type Conversions

[`Input-and-Type-Conversions/`](Input-and-Type-Conversions/) demonstrates `Console.ReadLine()`, `Parse`, `TryParse`, `Convert.ToInt32`, implicit conversion, and explicit casting through passenger information and calculation exercises.

### 3. Conditional Statements

[`Conditional-Statements/`](Conditional-Statements/) uses `if`, `else if`, `else`, and `switch` for password checks, exam results, team symbols, and month selection, together with remainder and logical operators.

### 4. Loops

[`Loops/`](Loops/) introduces `for`, `while`, `do-while`, and `foreach` through repeated output, even-number checks, and iteration over city names.

### 5. Arrays

[`Arrays/`](Arrays/) covers creation, indexing, traversal, user-entered values, summation, `Array.IndexOf`, and finding minimum and maximum values.

### 6. Collections

[`Collections/`](Collections/) explores `List<T>`, `Dictionary<TKey, TValue>`, `Queue<T>`, `Stack<T>`, and `HashSet<T>` through dynamic lists, key-value pairs, FIFO/LIFO processing, and unique values.

### 7. Methods

[`Methods/`](Methods/) demonstrates parameters, `void` and value-returning functions, and return values through customer cards, arithmetic, and exam results. These examples are local functions defined inside `Main`.

### 8. Classes and Objects

[`Classes-and-Objects/`](Classes-and-Objects/) introduces object creation, fields, instance methods, constructors, properties, and reference-type behavior using `Car`, `Student`, and `Product`.

### 9. Object-Oriented Programming

[`Object-Oriented-Programming/`](Object-Oriented-Programming/) demonstrates encapsulation with a bank account, inheritance and polymorphism with animals, abstraction with shapes, and interfaces with a duck that can fly and swim. Examples include `virtual`, `override`, and `abstract` members.

### 10. Exception Handling

[`Exception-Handling/`](Exception-Handling/) covers `try`, multiple `catch` blocks, `finally`, `throw`, and a custom `InsufficientBalanceException`. Examples handle invalid input, division by zero, age restrictions, and insufficient funds.

## ADO.NET and CRUD

[`ADO-NET-and-CRUD/`](ADO-NET-and-CRUD/) contains two console projects using `Microsoft.Data.SqlClient`:

| Project | Content |
| --- | --- |
| `DatabaseConnection/` | Opens a SQL connection, retrieves `TblCategory` with `SqlCommand` and `SqlDataAdapter`, and displays a `DataTable`. The menu reads a choice, but the current query always retrieves categories. |
| `DatabaseCRUD/` | Category insertion and product insertion, listing, deletion, and updating. Write operations use SQL parameters and `ExecuteNonQuery()`. |

The CRUD examples are commented out in separate regions. Uncomment the operation you want to practice before running that project.

## Entity Framework and Layered Architecture

This stage contains an Entity Framework practice application and a separate four-layer implementation. Both are included in [`Layered-Architecture.EntityLayer/Layered-Architecture.slnx`](Layered-Architecture.EntityLayer/Layered-Architecture.slnx).

### Entity Framework Practice Application

[`Layered-Architecture/EFProject/`](Layered-Architecture/EFProject/) contains `EFExample.csproj`, a Windows Forms application using Entity Framework 6 and a Database First model in `Model1.edmx`.

- `Form1`: guide listing, insertion, deletion, lookup, and update examples.
- `FRMLocation`: location management, guide selection, and displaying related guide names.
- `FRMStatistics`: counts, capacity totals and averages, average tour prices, and filtered location/guide statistics.

`EFExampleDBEntities` provides access to the generated model. The application currently starts with `FRMStatistics`; the guide and location forms are also present.

### Four-Layer Structure

The following directories are inside [`Layered-Architecture.EntityLayer/`](Layered-Architecture.EntityLayer/). Despite its name, this parent directory contains the entire layered solution.

| Directory | Responsibility |
| --- | --- |
| `Layered-Architecture.EntityLayer/` | `Admin`, `Category`, `Customer`, `Order`, and `Product` entities and their relationships, stored in `Concreate/`. |
| `Layered-Architecture.DataAccessLayer/` | `ExampleContext`, generic and entity-specific data access interfaces, `GenericRepository<T>`, Entity Framework implementations, and migrations. |
| `Layered-Architecture.BusinessLayer/` | Service interfaces and category, customer, order, and product managers in `Concreate/`. Managers delegate data operations; `CustomerManager` also performs basic insertion checks. |
| `Layered-Architecture.PresentationLayer/` | `FRMCategory`, which lists, adds, deletes, updates, and retrieves categories by ID through `ICategoryService`. |

Category requests pass from `FRMCategory` to `CategoryManager`, then to `EFCategoryDal` / `GenericRepository<Category>` and `ExampleContext`. The repository uses entity states and `SaveChanges()` for writes, `ToList()` for listing, and `DbSet.Find()` for primary-key lookup. The implemented presentation screen manages categories; other entities also have data access support.

### LINQ Usage

LINQ expresses filtering, projection, and aggregate operations in C#. The EF practice application contains the richer query examples:

- `Where` filters guides and locations.
- `Select` shapes grid rows and guide dropdown entries, including related guide names.
- `Count`, `Sum`, `Average`, and `Max` calculate statistics.
- `FirstOrDefault` retrieves a single projected result; `ToList` materializes results for display.

For example, `Form1.cs` filters guides by ID:

```csharp
var values = db.Guide.Where(x => x.GuideId == id).ToList();
```

In the four-layer application, current LINQ usage is limited to materializing repository results with `_object.ToList()`. ID lookup uses Entity Framework's `Find` method.

### Dependency Injection

Business managers receive their data access dependencies through constructors. For example, `CategoryManager` accepts `ICategoryDal`, allowing it to use the interface without constructing `EFCategoryDal` itself.

`FRMCategory` manually creates and connects the objects:

```csharp
_categoryService = new CategoryManager(new EFCategoryDal());
```

This is manual constructor injection into the manager. Customer, order, and product managers follow the same pattern. There is no DI container: the form constructs its service, and the generic repository creates its own `ExampleContext`.

## Local Database Connections

**`Integrated Security=True`**
Uses the currently logged-in Windows user's identity to connect, instead of a username and password. No password needs to be stored in the connection string.

**`TrustServerCertificate=True`**
Accepts the SQL Server's SSL certificate without validating it. It is used locally because development machines usually lack a trusted certificate; it is not recommended for production.

**Local databases**
The connection strings point to databases on the developer's own machine. Anyone cloning the repository must create these databases themselves and update the connection strings to match their own environment.

| Example | Database | Connection location |
| --- | --- | --- |
| ADO.NET | `ExampleDB` | `Program.cs` in both `ADO-NET-and-CRUD` projects. |
| EF Database First | `EFExampleDB` | `Layered-Architecture/EFProject/App.config`, under `EFExampleDBEntities`. |
| Four-layer application | `ExampleDB` | `Layered-Architecture.EntityLayer/Layered-Architecture.PresentationLayer/App.config`, under `ExampleContext`. |

To use another local SQL Server instance, adjust the relevant data source and database name. For Database First, preserve the Entity Framework metadata portion and edit the inner provider connection string.

ADO.NET uses `TblCategory` and `TblProduct`; the layered model uses entities such as `Category` and `Product`, with tables such as `Categories` and `Products`. Sharing the `ExampleDB` name does not make these schemas interchangeable.

No SQL setup scripts or database backups are included. The Database First schema is recorded in `Model1.edmx`. The layered project has automatic migrations enabled and a `mig1` migration that adds `CustomerStatus`; this is not a complete explicit initial schema migration. Prepare the matching schema and sample data locally before running database examples. The statistics screen expects populated tour data.

## Running the Examples

- **Console projects:** .NET 10 SDK; restore the declared NuGet dependencies for ADO.NET.
- **Windows Forms projects:** Windows, Visual Studio with .NET desktop development support, the .NET Framework 4.7.2 targeting pack, and restored NuGet packages. EF projects reference Entity Framework 6.5.2.
- **Database examples:** a local SQL Server instance with the expected databases, tables, and access permissions.

Run an individual console project from the repository root:

```sh
dotnet run --project Variables-and-Data-Types/Variables-and-Data-Types.csproj
```

For Windows Forms, open `Layered-Architecture.EntityLayer/Layered-Architecture.slnx` in a Visual Studio version that supports `.slnx`. Choose `EFExample` for the statistics application or `Layered-Architecture.PresentationLayer` for category management as the startup project.

These are learning exercises with small examples and limited input validation, recording the progression from individual language features to database-backed application structure.
