/*
// Author: Isaac Martinez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.
*/
using System.Diagnostics;

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

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddProduct(productNames, productQuantities);
                            break;
                        case 2:
                            UpdateProductQuantity(productNames, productQuantities);
                            break;
                        case 3:
                            ViewInventorySummary(productNames, productQuantities);
                            break;
                        case 4:
                            Console.WriteLine("Goodbye.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Choice. Please try again");
                }
            }
        }

        static void AddProduct(List<string> productNames, List<int> productQuantities)
        {
            Console.WriteLine("\nPlease Enter product name: ");
            string productName = Console.ReadLine();

            Console.Write("Please Enter product quantity: ");
            if (int.TryParse (Console.ReadLine(), out int productQuantity))
            {
                productNames.Add(productName);
                productQuantities.Add(productQuantity);
                Console.WriteLine("Product added succefully!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid quantity");
            }
        }

        static void UpdateProductQuantity(List<string>productNames,  List<int> productQuantities)
        {
            Console.WriteLine("Please Enter product name to update: ");
            string nameUpdated = Console.ReadLine();
            int index = productNames.IndexOf (nameUpdated);

            if (index != -1)
            {
                Console.Write("Enter new quantity");
                if (int.TryParse(Console.ReadLine(), out int newQuantity))
                {
                    productQuantities [index] = newQuantity;
                    Console.WriteLine("Product quantity updated successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid quantity");
                }
            }
            else
            {
                Console.WriteLine("Product not found. Please try again.");
            }
        }

        static void ViewInventorySummary(List<string> productNames, List<int>productQuantities)
        {
            Console.WriteLine("Inventory Summary:");
            int totalQuantity = 0;
            for (int i = 0; i < productNames.Count; i++)
            {
                Console.WriteLine($"{productNames[i]}: {productQuantities[i]}");
                totalQuantity += productQuantities[i];
            }
            Console.WriteLine($"Total Products: {productNames.Count}");
            Console.WriteLine($"Total Quantity: {totalQuantity}");
            Console.WriteLine($"Average Quantity: {(productNames.Count > 0 ? (totalQuantity / productNames.Count) : 0)}");
        }
    }
}
