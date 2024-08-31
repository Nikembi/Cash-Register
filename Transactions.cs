using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register
{
    public class Transactions
    {
        public int Transaction { get; set; }
        
        public string ProductName { get; set; }
        public double Charge { get; set; }
        public double CashGiven { get; set; }
        public double ChangeGiven { get; set; }
    }      
}
