using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTasks_game_
{
    public class Atm
    {
        public int Id;
        public int Amount;
        public int NewCreateCarAmount;
        public DateTime dates;
        public string Name;
        //
        public Atm(int newcreate,DateTime dateTime,string nm)
        {
            NewCreateCarAmount = newcreate;
            dates = dateTime;
            Name = nm;
        }
    }
}
