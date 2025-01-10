using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBillingApplication
{
    public class BillTypeHotel
    {
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
