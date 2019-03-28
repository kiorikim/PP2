using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PusrchaseOrder
{
    public class PurchaseOrder
    {

        public Address address;
        public string OrderDate;
        public List<OrderItem> OrderItems;
        public PurchaseOrder() { }
        public PurchaseOrder(string OrderDate, Address address)
        {
            this.OrderDate = OrderDate;
            this.address = address;
            OrderItems = new List<OrderItem>();
        }
        public void Save(PurchaseOrder order)
        {
            //StreamWriter sw = new StreamWriter("order.txt");
            //sw.WriteLine("Address");
            //sw.WriteLine(address.Name);
            //sw.WriteLine(address.City);
            //sw.WriteLine(address.State);
            //sw.WriteLine(address.Zip);
            //sw.WriteLine(OrderDate);
            //for (int i=0;i<OrderItems.Count;i++)
            //{
            //    sw.WriteLine(OrderItems[i].ItemName);
            //    sw.WriteLine(OrderItems[i].Description);
            //    sw.WriteLine(OrderItems[i].Quantity);
            //    sw.WriteLine(OrderItems[i].UnitPrice);
            //    sw.WriteLine(OrderItems[i].Total);
            //}
            //sw.Close();
            FileStream fs = new FileStream("order.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(PurchaseOrder));
            xs.Serialize(fs, order);
            fs.Close();
        }
    }
    public class Address
    {
        public string Name;
        public string City;
        public string State;
        public string Zip;
        public Address() { }
        public Address(string Name, string City, string State, string Zip)
        {
            this.Name = Name;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
        }
    }
    public class OrderItem
    {
        public string ItemName;
        public string Description;
        public int UnitPrice;
        public int Quantity;
        public int Total;
        public OrderItem() { }
        public OrderItem(string ItemName, string Description, int UnitPrice, int Quantity)
        {
            this.ItemName = ItemName;
            this.Description = Description;
            this.UnitPrice = UnitPrice;
            this.Quantity = Quantity;
            this.CalcTotal();
        }
        public void CalcTotal()
        {
            Total = UnitPrice * Quantity;
        }
    }
}
