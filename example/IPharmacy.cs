using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
   interface IPharmacy
    {
        public List<Medicine> Book { get; set; }
        public void Medicines(string medicine);
        public void Sell(string medicineName, int count);
        public Medicine FindMedicineByName(string medicineName);
        public void AddMedicine(string medicine);
    }
}
