using System.Data;
using Microsoft.Data.SqlClient;

namespace DatabaseCRUD;

internal class Program
{
    static void Main(String[] args)
    {
        // CRUD -> Create-Read-Update-Delete
        // YOU CAN APPLY IT BY UNCOMMENTING THE RELEVANT REGION SECTION.


        //Console.WriteLine("**** Menu Order Processing Panel ****");
        //Console.WriteLine("-------------------------------------");

        #region CategoryAdditionProcess

        //Console.WriteLine("Enter the category you would like to add: ");
        //string categoryName = Console.ReadLine();

        // Connects to the local SQL Server database (ExampleDB).
        //SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS; initial catalog=ExampleDB;integrated security=true;TrustServerCertificate=True");
        //connection.Open();
        //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
        //command.Parameters.AddWithValue("@p1", categoryName);
        //command.ExecuteNonQuery();
        //connection.Close();

        //Console.WriteLine("Category added successfully!");

        #endregion

        #region ProductAdditionProcess

        //string productName;
        //decimal productPrice;
        // bool productStatus;

        //Console.Write("Product Name: ");
        //productName = Console.ReadLine();
        //Console.Write("Product Price: ");
        //productPrice = decimal.Parse(Console.ReadLine());

        //SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS; initial catalog=ExampleDB; integrated security=true; TrustServerCertificate=True");
        //connection.Open();
        //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
        //command.Parameters.AddWithValue("@productName", productName);
        //command.Parameters.AddWithValue("@productPrice", productPrice);
        //command.Parameters.AddWithValue("@productStatus", true);
        //command.ExecuteNonQuery();
        //connection.Close();
        //Console.WriteLine("Product added successfully!");

        #endregion

        #region ProductListingProcess

        //SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS; initial catalog=ExampleDB; integrated security=true; TrustServerCertificate=True");
        //connection.Open();
        //SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
        //SqlDataAdapter adapter = new SqlDataAdapter(command);
        //DataTable dataTable = new DataTable();
        //adapter.Fill(dataTable);

        //foreach (DataRow row in dataTable.Rows) 
        //{ 
        //    foreach (var item in row.ItemArray)
        //    {
        //        Console.Write(item.ToString() + " ");
        //    }
        //    Console.WriteLine();
        //}

        //connection.Close();

        #endregion

        #region ProductDeletionProcess

        //Console.Write("Product ID to be deleted: ");
        //int productId=int.Parse(Console.ReadLine());


        //SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS; initial catalog=ExampleDB; integrated security=true; TrustServerCertificate=True");
        //connection.Open();
        //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
        //command.Parameters.AddWithValue("@productId", productId);
        //command.ExecuteNonQuery();

        //connection.Close();

        //Console.WriteLine("Product deleted successfully!");

        #endregion

        #region ProductUpdateProcess

        //Console.Write("ID of the product to be updated:");
        //int productId = int.Parse(Console.ReadLine());
        //Console.Write("Name of the product to be updated: ");
        //string productName = Console.ReadLine();
        //Console.Write("Price of the product to be updated: ");
        //decimal productPrice = decimal.Parse(Console.ReadLine());

        //SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS; initial catalog=ExampleDB; integrated security=true; TrustServerCertificate=True");
        //connection.Open();
        //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice Where ProductId=@productId",connection);
        //command.Parameters.AddWithValue("@productId", productId);
        //command.Parameters.AddWithValue("@productName", productName);
        //command.Parameters.AddWithValue("@productPrice", productPrice);
        //command.ExecuteNonQuery();
        //connection.Close();

        //Console.WriteLine("Product updated successfully!");

        #endregion

        Console.Read();


    }
}