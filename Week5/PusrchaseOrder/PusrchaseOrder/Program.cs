using System;
using System.IO;
using System.Xml.Serialization;

namespace PusrchaseOrder
{
    class Program
    {
        public static void F1()
        {
            Address address = new Address();
            address.Name = "Kim Kiori";
            address.City = "Almaty";
            address.State = "Almaly";
            address.Zip = "050000";
            OrderItem item1 = new OrderItem("Item1", "Item 1 description", 100, 2);
            OrderItem item2 = new OrderItem("Item2", "Item 2 description", 50, 3);
            PurchaseOrder order = new PurchaseOrder("21.02.2019", address);
            order.OrderItems.Add(item1);
            order.OrderItems.Add(item2);
            order.Save(order);
        }
        public static void F2()
        {
            FileStream fs = new FileStream("order.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(PurchaseOrder));
            PurchaseOrder order = xs.Deserialize(fs) as PurchaseOrder;
            fs.Close();
            Console.WriteLine(order.OrderItems[0].ItemName);
        }
        static void Main(string[] args)
        {
            //F1();
            F2();
        }
    }
}
