using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public class Cmoputer
    {
        public Cmoputer()
        {
            
        }

        public string CompanyName { get; set; }
        public int  Price { get; set; }
        public string WarrantyYear { get; set; }
        public bool Workable { get; set; }

        public string GetComputer {
            get {
                return $" Company name {CompanyName}, Price ${Price}, Year of Warranty {WarrantyYear}, " +
                    $"and Computer is warkable condition {Workable}";
                         }
                     }


    }
}
