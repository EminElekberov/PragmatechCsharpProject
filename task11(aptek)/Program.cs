using System;

namespace task11_aptek_
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine med = new Medicine("Adalzit", 20, 30);
            
            Medicine med2 = new Medicine("nospa", 20, 30);
            //
            //Medicine med2 = new Medicine("Adalzit2", 40)
            //{
            //    Name = "Adalzit2",
            //    Price = 40,
            //    Count = 20
            //};
            Pharmacy ph = new Pharmacy();
            ph.Books.Add(med);
            ph.Books.Add(med2);
            // ph.Medicines("nospa");
            ph.Sell("Adalzit", 10);
            ph.Sell("Adalzit", 10);
            //ph.Sell("adalzit", 10);
            ph.Sell("nospa", 15);
            Console.WriteLine("-----------------");

            //ph.FindMedicineByName("buhbuhb");
            //ph.AddMedicine(new Medicine("nospa", 80, 20));
        }
    }
}
