/*
// Author: Isaac Martinez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.
*/
namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management System!!");
            Console.WriteLine("Data storage type: List"); // if you read this, sorry don't know how to set both options up

            List<string> productNames = new List<string>();
            List<int> productQuantity = new List<int>();

            while (true)
            {
                Console.WriteLine("\nInventory Management System Menu::");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                int choice = int.Parse(Console.ReadLine());

            }
        }
    }
}
