using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Inventory.addPart(new InHouse(1, "Small Screw", 0.37m, 467, 1, 500, 456897412));
            Inventory.addPart(new InHouse(2, "Large Screw", 0.75m, 200, 1, 500, 456897413));
            Inventory.addPart(new InHouse(3, "Wheel", 5.56m, 20, 1, 25, 456897415));
            Inventory.addPart(new Outsource(4, "Blue Paint", 10.00m, 5, 1, 25, "Meyer's Paint Company"));
            Inventory.addPart(new Outsource(5, "Red Paint", 10.00m, 5, 1, 25, "Meyer's Paint Company"));
            Inventory.addPart(new Outsource(6, "Green Paint", 10.00m, 5, 1, 25, "Meyer's Paint Company"));
            Inventory.addPart(new Outsource(7, "Yellow Paint", 10.00m, 5, 1, 25, "Meyer's Paint Company"));
            Inventory.addPart(new InHouse(8, "Metal Rod", 15.00m, 12, 1, 25, 456897418));
            Inventory.addProduct(new Product("Blue Wheel", 25.50m, 1, 1, 5));
            Inventory.addProduct(new Product("Violet Rod", 7.50m, 1, 1, 5));
            Inventory.addProduct(new Product("Bundle of Screws", 25.50m, 1, 1, 5));


            Application.Run(new MainScreen());

        }
    }
}
