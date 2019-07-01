using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
namespace Task1
{
    public class Shop
    {
        public List<Products> productsList;
        public string shopName;
        public string shopType;
        public Shop() { }
        public Shop(string shopName, string shopType)
        {
            productsList = new List<Products>();
            Products p1 = new Products();
            Products p2 = new Products();
            p1.name = "one";
            p1.price = 100;
            p2.name = "two";
            p2.price = 1000;
            productsList.Add(p1);
            productsList.Add(p2);
            this.shopName = shopName;
            this.shopType = shopType;
        }
        public override string ToString()
        {
            return shopName + " " + shopType;
        }
    }

    public class Products
    {
        public string name;
        public int price;
        public Products() { }
        public Products(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }


}
