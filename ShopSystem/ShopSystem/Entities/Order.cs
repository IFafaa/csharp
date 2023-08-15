using ShopSystem.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystem.Entities {
    internal class Order {
        public DateTime Moment {get; private set;}
        public OrderStatus Status { get; set;}
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(OrderStatus status ,Client client) {
            Status = status;
            Moment = DateTime.Now;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            OrderItems.Remove(item);
        }

        public double Total() {
            double total = 0;
            OrderItems.ForEach(item => total += item.subTotal());
            return total;
        }

        public override string ToString() {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Order moment: {Moment.ToString()}");
            str.AppendLine($"Order status: {Status}");
            str.AppendLine($"Client: {Client.ToString()}");
            str.AppendLine("Oder items:");
            OrderItems.ForEach(item => str.AppendLine(item.ToString()));
            str.AppendLine($"Total: ${Total()}");
            return str.ToString();

        }

    }
}
