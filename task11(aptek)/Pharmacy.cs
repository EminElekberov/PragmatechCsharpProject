using System;
using System.Collections.Generic;
using System.Text;

namespace task11_aptek_

{
    
   public class Pharmacy : IPharmacy
    {
        public List<Medicine> Books { get; set; }
        public Pharmacy()
        {
            this.Books = new List<Medicine>();
        }
        List<Medicine> IPharmacy.Books { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double TotalInCome => throw new NotImplementedException();

        public void Medicines(string medicine)
        {
            string find = medicine.Trim().ToLower();
            Medicine med = Books.Find(n => n.Name.Trim().ToLower().Equals(find));
            if (med != null)
            {
                Console.WriteLine($"name {med.Name} \n Count  {med.Count} \n " +
                    $"price {med.Price}");
            }
            else
            {
                Console.WriteLine("bele derman tapilmadi");
            }
            #region

            //string med = medicine.Trim().ToLower();
            //List<Medicine> show = Books.FindAll(s => s.Name.Trim().ToLower().Contains(med));
            //foreach (var item in Books)
            //{
            //    Console.WriteLine($"name {item.Name} price {item.Price} ");
            //}
            #endregion
        }
       
        public void Sell(string medicineName, int buyProductCount)
        {
            string mediName = medicineName.Trim().ToLower();
            bool existName = false;
           Medicine sell = Books.Find(s => s.Name.Trim().ToLower().Equals(mediName));
                if (sell.Count > buyProductCount)
                {
                    sell.Count -= buyProductCount;
                    double resultprice = buyProductCount * sell.Price;
                    Medicine._totalInCome += resultprice;
                    Console.WriteLine($"umumi qiymet{resultprice} manat, " +
                        $"bazada ise umumi satisdan elde edilen gelir{Medicine._totalInCome} manat");
                }
                else
                {
                    throw new CountException("kifayte qeer mehsul yoxdur");
                }
            
            #region
            //foreach (var item in Books)
            //{
            //    if (medicineName==item.Name && item.Count > buyProductCount)
            //    {
            //        item.Count -= buyProductCount;
            //        double result = buyProductCount * item.Price;
            //         item._totalInCome = result;
            //        Console.WriteLine($"{buyProductCount} mehsul satildi ve umumi qiymet{result} manat, " +
            //        $"bazada ise umumi satisdan elde edilen gelir{item._totalInCome} manat");
            //    }

            //}
            #endregion
        }

        
        public Medicine FindMedicineByName(string medicineName)
        {
            string med = medicineName.Trim().ToLower();
            Medicine med1 = Books.Find(m => m.Name.Trim().ToLower().Equals(med));
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

        public void Find(string medicineName)
        {
            string mediName = medicineName.Trim().ToLower();
            Medicine tot = Books.Find(t => t.Name.Trim().ToLower().Contains(mediName));
            foreach (var item in Books)
            {
                Console.WriteLine(item);
            }
        }
        public void AddMedicine(Medicine medicine)
        {
            string lowercase = medicine.Name.Trim().ToLower();
            Medicine newmedicine = Books.Find(f => f.Name.Trim().ToLower().Equals(medicine.Name.ToLower().Trim()));
            if (newmedicine == null)
            {
                Books.Add(medicine);
            }
            else
            {
                Console.WriteLine("elave olundu");
            }
        }
    }
}
