using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRepeat
{
    public class Imedicine
    {
        #region
        //public void Medicines(string medicine);
        //public void Sell(string medicineName, int buyProductCount);
        //public Medicine FindMedicineByName(string medicineName);
        //public void AddMedicine(Medicine medicine);
        #endregion

        public List<Medicine> Books;
        public Imedicine()
        {
            Books = new List<Medicine>();
        }
        public void Medicinesd(string medicine)
        {
            string med = medicine.Trim().ToLower();
            Medicine bok = Books.Find(x => x.Name.Trim().ToLower().Equals(med));
            if (bok!=null)
            {
                Console.WriteLine($"{bok.Name} {bok.Price} {bok.Count}");
            }
            else
            {
                Console.WriteLine("Bu derman yoxdur");
            }
        }
        public void Sell(string medName,int BuyCount)
        {
            string name = medName.Trim().ToLower();
            Medicine med = Books.Find(x => x.Name.Trim().ToLower().Equals(name));
            if (med.Count>BuyCount)
            {
                med.Count -= BuyCount;
                double result = BuyCount * med.Price;

            }
        }
        public Medicine Find(string name)
        {
            string nm = name.Trim().ToLower();
            Medicine med = Books.Find(x => x.Name.Trim().ToLower().Equals(nm));
            if (med!=null)
            {
                Console.WriteLine(med.Name);
            }
            else
            {
                Console.WriteLine("bele bir derman yoxdur");
            }
            return med;
        }
        public void AddMedicine(Medicine medicine )
        {
            string nm = medicine.Name.Trim().ToLower();
            Medicine med = Books.Find(x => x.Name.Trim().ToLower().Equals(nm));
            foreach (var item in Books)
            {
                if (med!=null)
                {
                    Books.Add(med);
                }
                else
                {
                    Console.WriteLine("elave olundu");
                }
            }
        }
    }
}
