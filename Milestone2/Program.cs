using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Miguel Torres Perez
// CST-150

namespace Milestone2
{
    class InventoryManager

    {
        static void Main(string[] args)
        {
            InventoryItem item = new InventoryItem("Cherry", 1.50, 5, "Cherry Ice Cream");
            Console.WriteLine("New Item: " + "\nItem Flavor: " + item.Flavor
                + "\nItem Price: " + item.Price + "\nQuantity of item: "
                + item.Quantity + "\nItem Description: " + item.Description);
            Console.ReadKey();
        }
    }
}
