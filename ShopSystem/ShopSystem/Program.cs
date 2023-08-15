using ShopSystem.Entities;
using ShopSystem.Entities.Enums;
using System;

namespace ShopSystem
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data ( PENDING_PAYMENT / PROCESSING / SHIPPED / DELIVERED)");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status, client);
            Console.Write("How many items to this order? ");
            int quantityItems = int.Parse(Console.ReadLine());
            for(int i = 0; i < quantityItems; i++) {
                Console.WriteLine($"\nEnter #{i + 1} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine("\n\nORDER SUMMARY:");
            Console.WriteLine(order.ToString());



        }
    }
}