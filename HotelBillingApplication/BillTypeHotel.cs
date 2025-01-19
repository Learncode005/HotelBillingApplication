using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBillingApplication
{
    public class BillTypeHotel
    {
        // Create a dictionary to store items and their prices
     
        public void GetInputForBill()
        {
            Dictionary<string, string> items = new Dictionary<string, string>
             {
                 {"1", "Tiffin 30" },
                 { "2", "Meals 40" }
              };

            // Display the items and their prices
            Console.WriteLine("Item List and Prices:");
           

            Console.WriteLine("Enter Item:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string itemName = Console.ReadLine();
            Console.WriteLine($"Entered item name:{ itemName}");


            if (itemName != null)
            {
                string value ="";
         if(items.TryGetValue(itemName, value: out value))
                {
                    Console.WriteLine(value);
                }
                //foreach (var item in items)
                //{
                //    if(itemName == item.Key.ToString())
                //    {
                //        Console.WriteLine($"{item.Key}:   ${item.Value}");
                //    }
                   
                //}
            }
        }
        public bool GenerateTheHoteBill(int billNo)
        {
            
            Console.WriteLine("               Sri LaxmiGanapthi Hotel");
            Console.WriteLine("                   Dundigal X Road");
            Console.WriteLine("                  ");
            Console.WriteLine("                  ");
            DateTime localDate = DateTime.Now;
            Console.WriteLine($"Bill no: {billNo}  Date :{localDate.Date.Date.ToShortDateString()}");//datetime .now inbuild funnction
            Console.WriteLine($"              Time : {localDate.ToLongTimeString()}    ");
            //Billing footer 1
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Item :  Quantity   Price      Amount");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Tiffin:  1P       40.00   40.00");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Total              40.00");
            Console.WriteLine("-------------------------------------------------");
            //footer
            Console.WriteLine("           Thank You Visit Again");
            //Console.WriteLine(" Software By: Learncode005YoutubeChannel");

            Console.ReadLine();

            return true;
        }
    }
}
