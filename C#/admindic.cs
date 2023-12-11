using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class admindic
    {
         string name;
        int ID;
        decimal price;
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
        public int id
        {
            get
            {
                return ID;
            }
            set
            {
                if (value >= 1)
                {
                    ID = value;
                }
                else
                {
                    
                }
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0 )
                {
                    price = value;
                }
                else
                {
                   
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
                if (value >= 1 )
                {
                    qty = value;
                }
                else
                {
                    qty = 0;
                }
            }
        }
    
    }
}
