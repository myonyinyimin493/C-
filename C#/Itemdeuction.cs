using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Itemdeuction
    {
        int ID;
        int qty;

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

        public int Qty
        {
            get
            {
                return qty;
            }
            set
            {
                if (value >= 1)
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
