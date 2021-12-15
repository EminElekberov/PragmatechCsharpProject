using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    public class Pharmacy : IPharmacy
    {
        public List<Medicine> Book { get ; set; }

        public Pharmacy()
        {
            this.Book = new List<Medicine>();
        }
        public void Medicines(string medicine)
        {
            string med = medicine.Trim().ToLower();
            Medicine med1 = Book.Find(m => m.Name.Trim().ToLower().Equals(med));
            if (med!=null)
            {
                Console.WriteLine($"name {med1.Name} coount {med1.Count} price {med1.Price}");
            }
            else
            {
                Console.WriteLine("bele bir derman yoxdur");
            }
        }
        public void Sell(string medicineName, int count)
        {
            string med = medicineName.Trim().ToLower();
            Medicine med1 = Book.Find(m => m.Name.Trim().ToLower().Equals(med));
            if (med1.Count>count)
            {
                med1.Count -= count;
                double resultPrice = count * med1.Price;
                Medicine._totalInCome += resultPrice;
                Console.WriteLine($"umumi qiymet{resultPrice} manat, " +
                        $"bazada ise umumi satisdan elde edilen gelir{Medicine._totalInCome} manat");
            }
            else
            {
                Console.WriteLine("kifayet qeder mehsul yoxdur");
            }
        }
       

        public Medicine FindMedicineByName(string medicineName)
        {
            string med = medicineName.Trim().ToLower();
            Medicine med1 = Book.Find(m => m.Name.Trim().ToLower().Equals(med));
            if (med1!=null)
            {
                Console.WriteLine(med1.Name);
            }
            else
            {
                Console.WriteLine("false");
            }
            return med1;
        }
        public void AddMedicine(string medicine)
        {
            string med = medicine.Trim().ToLower();
            Medicine med1 = Book.Find(m => m.Name.Trim().ToLower().Equals(med));
            //if (med1.Name==medicine)
            //{
            //    med1.Count += medicine;
            //}
            foreach (var item in Book)
            {
                if (item.Name == med1.Name)
                {
                    item.Count += med1.Count;
                }
                else
                {
                    Book.Add(med1);
                }
            }
        }
    }
}
