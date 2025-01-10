// See https://aka.ms/new-console-template for more information

//header

GenerateThevegetableBill();
  bool GenerateThevegetableBill()
{
    Console.WriteLine("               F&V EnterPrises");
    Console.WriteLine("               plot no 1708, 1709");
    Console.WriteLine("          laxmi chennakeshava complex");
    Console.WriteLine("        Opp:Srikrishna Gardens Pragathi nagar,Hyd 90");
    Console.WriteLine("           Phone Number: 9887766433433");
    Console.WriteLine("                   Gst: 123456");

    Console.WriteLine("Cash Bill");
    DateTime localDate = DateTime.Now;
    Console.WriteLine($"Bill no: 123  Date :{localDate}");//datetime .now inbuild funnction
    Console.WriteLine("Counter no:   Ref:234 ");
    //Billing footer 1
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Sno no:  Description  Rate    Quantity    Amount");
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("1:       Bajji Mirchi 89PerKg  0.225    20.03");
    Console.WriteLine("-------------------------------------------------");

    Console.WriteLine("Items: 1          Bill Amount     20.03");
    Console.WriteLine("quantity: 1       Received Amount  20.03");

    Console.WriteLine("Mode: 1          Card           Change:0.00");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    //billing footer 2
    Console.WriteLine("Taxable         SGST     CGST      Total Amount  ");
    Console.WriteLine("-------------------------------------------------");
    //footer
    Console.WriteLine("           Thank You Visit Again");
    Console.WriteLine("Printed : 29/12/2024    11:20PM");
    Console.WriteLine(" Software By: Learncode005YoutubeChannel");

    Console.ReadLine();

    return true;
}