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
            Console.WriteLine("Data storage type: List"); // if you read this, sorry don't know how to set both options

            List<string> productNames = new List<string>();
            List<int> productQuantities = new List<int>();

            while (true)
            {
                Console.WriteLine("\nInventory Management System Menu:");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("\nPlease Enter product name: ");
                        string productName = Console.ReadLine();
                        Console.Write("Please Enter product quantity: ");
                        int productQuantity = int.Parse(Console.ReadLine());

                        productNames.Add(productName);
                        productQuantities.Add(productQuantity);
                        Console.WriteLine("Product added successfully!");
                        break;
                    case 2:
                        Console.Write("Please Enter product name to update: ");
                        string nameUpdated = Console.ReadLine();
                        int index = productNames.IndexOf(nameUpdated);
                        if (index != -1)
                        {
                            Console.Write("Enter new quantity: ");
                            int newQuantity = int.Parse(Console.ReadLine());
                            productQuantities[index] = newQuantity;
                            Console.WriteLine("Product quantity updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please try again");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Inventory Summary:");
                        int totalQuantity = 0;
                        for (int i = 0; i < productNames.Count; i++)
                        {
                            Console.WriteLine($" {productNames[i]}: {productQuantities[i]}");
                            totalQuantity += productQuantities[i];
                        }
                        Console.WriteLine($"Total Products: {productNames.Count}");
                        Console.WriteLine($"Total Quantity: {totalQuantity}");
                        Console.WriteLine($"Average Quantity: {(productNames.Count > 0 ? (totalQuantity / productNames.Count) : 0)}");
                        break;
                    case 4:
                        Console.WriteLine("Goodbye.");
                        return;
                        break;
                }
            }
        }
    }
}
