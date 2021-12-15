using System;
using System.Collections.Generic;
using System.Text;

namespace task7_OOP_
{
    abstract class Account
    {
        
        public abstract bool PasswordChecker(string pass);
        public virtual void ShowInfo()
        {
            
        }
    }
}
