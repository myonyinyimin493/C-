using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class adminn
    {
        string name;
        int price;
        int qty;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    name = "unknown name";
                }
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 1 )
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }
        public int Qty
        {
            get
            {
                return qty;
            }
            set
            {
                if (value >= 0 )
                {
                    qty = value;
                }
                else
                {
                    
                }
            }
        }
    }
}
