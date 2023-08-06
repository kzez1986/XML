﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LinqToXmlFirstLook
{
    class Program
    {
        static void Main(string[] args)
        {
            DeleteNodeFromDoc();
        }

        private static void BuildXmlDocWithLINQToXml()
        {
            XElement doc = new XElement("Inventory", new XElement("Car", new XAttribute("ID", "1000"), new XElement("PetName", "Jimbo"), new XElement("Color", "Red"), new XElement("Make", "Ford")));
            doc.Save("InventoryWithLINQ.xml");
        }

        private static void DeleteNodeFromDoc()
        {
            XElement doc = new XElement("Inventory", new XElement("Car", new XAttribute("ID", "1000"), new XElement("PetName", "Jimbo"), new XElement("Color", "Red"), new XElement("Make", "Ford")));
            doc.Descendants("PetName").Remove();
            Console.WriteLine(doc);
            Console.ReadLine();
        }

        private static void BuildXmlDocWithDOM()
        {
            XmlDocument doc = new XmlDocument();

            XmlElement inventory = doc.CreateElement("Inventory");

            XmlElement car = doc.CreateElement("Car");
            car.SetAttribute("ID", "1000");

            XmlElement name = doc.CreateElement("PetName");
            name.InnerText = "Jimbo";
            XmlElement color = doc.CreateElement("Color");
            color.InnerText = "Red";
            XmlElement make = doc.CreateElement("Make");
            make.InnerText = "Ford";

            car.AppendChild(name);
            car.AppendChild(color);
            car.AppendChild(make);

            inventory.AppendChild(car);

            doc.AppendChild(inventory);
            doc.Save("Inventory.xml");
        }
    }
}
