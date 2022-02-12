using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTasks_game_
{
    public class Cards
    {
        public List<Atm> atms { get; set; }
        public Cards()
        {
            this.atms = new List<Atm>();
        }
        public  void ShowAllCards()
        {
            foreach (var item in atms)
            {
                Console.WriteLine(item.Name + " " + item.NewCreateCarAmount);
            }
        }
        public void Add(Atm atm)
        {
            bool existName = false;
            foreach (var item in atms)
            {
                if (item.NewCreateCarAmount== atm.NewCreateCarAmount)
                {
                    existName = true;
                }
            }
            if (!existName)
            {
                atms.Add(atm);
            }
            else
            {
                Console.WriteLine("this book exist");
            }

        }
        public void ShowInfo(string cartName)
        {
                Atm info = atms.Find(n => n.Name.Trim().ToLower() == cartName.Trim().ToLower());
                if (info != null)
                {
                    Console.WriteLine($"name {info.Name} \n amount{info.NewCreateCarAmount} \n " +
                        $"pagecount {info.dates}");
                }
                else
                {
                    Console.WriteLine("this card is not found");
                }
            
            
        }
        public void Remove(string crdName)
        {
            string removeCards = crdName.Trim().ToLower();
            if (removeCards==null)
            {
                Console.WriteLine("kart adini girin");
            }
            Atm remove = atms.Find(r => r.Name.Trim().ToLower().Contains(removeCards));
            if (remove != null)
            {
                atms.Remove(remove);
                Console.WriteLine("silindi");
            }
            else
            {
                Console.WriteLine("card is not found");
            }
        }
       
    }
}
