using System;
using System.Collections.Generic;
using System.Text;

namespace task11_aptek_
{
    interface IPharmacy
    {
        public List<Medicine> Books { get; set; }
        public void Medicines(string medicine);
        public void Sell(string medicineName,int buyProductCount);
        public Medicine FindMedicineByName(string medicineName);
        public void AddMedicine(Medicine medicine);

    }
}
