using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class Product : Inventory
    {
        public static int count = 0;
        public int ProductID { get; set; }
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock{ get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int ProductID, string Name, decimal Price, int InStock, int Min, int Max)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
        }

        public Product(string Name, decimal Price, int InStock, int Min, int Max)
        {
            this.ProductID = count++;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
        }
        public void addAssociatedPart(Part obj) 
        {

            AssociatedParts.Add(obj);
        }

        //redo below
        public bool removeAssociatedPart(int PartID) 
        {
            Part part = AssociatedParts.SingleOrDefault(predicate => predicate.PartID == PartID);
            bool isRemoved = AssociatedParts.Remove(part);
            return isRemoved;
        }
        public Part lookupAssociatedPart(int PartID) 
        {
            Part part = AssociatedParts.SingleOrDefault(predicate => predicate.PartID == PartID);
            return part;
        }
    }
}
    