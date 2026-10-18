using System.Data;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace ADO_NET_and_CRUD;

internal class Program
{
    static void Main(string[] args)
    {
        // Ado.net
        Console.WriteLine("*** C# database-driven product-category information system ***");
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("1 - Categories");
        Console.WriteLine("2 - Products");
        Console.WriteLine("3 - Orders");
        Console.WriteLine("4 - Quit");
        Console.WriteLine("Please enter the table number you would like to bring: ");
        string tableNumber = Console.ReadLine();
        Console.WriteLine("---------------------------------------------------------");

        SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;initial Catalog=ExampleDB;integrated security=true;TrustServerCertificate=True");
        connection.Open();
        SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);
        connection.Close();

        foreach (DataRow row in dataTable.Rows)
        {
            foreach (var item in row.ItemArray)
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine();
        }

        Console.Read();
    }
}