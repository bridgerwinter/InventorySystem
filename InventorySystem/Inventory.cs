using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void addProduct(Product obj) 
        {
            Products.Add(obj);
        }
        public static bool removeProduct(int ProductID) 
        {
            Product product = Products.SingleOrDefault(predicate => predicate.ProductID == ProductID);
            bool isRemoved = Products.Remove(product);
            return isRemoved;
        }
        public static Product lookupProduct(int ProductID)
        { 
            Product product = Products.SingleOrDefault(predicate => predicate.ProductID == ProductID);
            return product;
        }
        public static void updateProduct(int productID, Product obj) 
        {
            Product product = lookupProduct(productID);
            product.AssociatedParts = obj.AssociatedParts;
            product.InStock = obj.InStock;
            product.Max = obj.Max;
            product.Min = obj.Min;
            product.Name = obj.Name;
            product.Price = obj.Price;
            product.ProductID = obj.ProductID;
        
        }

        public static void addPart(Part obj) 
        {
            AllParts.Add(obj);
        }
        public static bool deletePart(Part obj) 
        {
            bool isRemoved = AllParts.Remove(obj);
            return isRemoved;
        }
        public static Part lookupPart(int PartID) 
        {
            Part part = AllParts.SingleOrDefault(predicate => predicate.PartID == PartID);
            return part;
        }
        public static void updatePart(int PartID, Part prelimObj) 
        {
            Part part = lookupPart(PartID);
            if (prelimObj is InHouse)
            {
                InHouse obj = (InHouse)prelimObj;
                deletePart(part);
                InHouse ih = new InHouse(obj.PartID, obj.Name,obj.Price, obj.InStock, obj.Min, obj.Max, obj.MachineID);
                addPart(ih);
            }
            else
            {
                Outsource obj = (Outsource)prelimObj;
                deletePart(part);
                Outsource os = new Outsource(obj.PartID, obj.Name, obj.Price, obj.InStock, obj.Min, obj.Max, obj.CompanyName);
                addPart(os);
            }


        }


}
}
