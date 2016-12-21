using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormMVC.Model
{
    public class Item
    {

        private string id;
        private string name;
        private double price;
        private string unit;
        private string description;
        private bool isActive;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public Item(string id, string name, double price, string unit, string description)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.unit = unit;
            this.description = description;
            this.isActive = true;
        }

        public Item()
        {

        }
    }
}
