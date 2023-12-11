using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class casheer
    {
        string itemname;
        string customern;
        string vouncher;
        int ID;
        decimal price;
        int qty;
        decimal amount;
        //int subtot;
        //int ta;
        //int tot;
        //int dis;
        //int pay;
        public string CName
        {
            get
            {
                return customern;
            }
            set
            {
                if (value != "")
                {
                    customern = value;
                }
                else
                {
                    customern = "unknown name";
                }
            }
        }
        public string Vouncher
        {
            get
            {
                return vouncher;
            }
            set
            {
                if (value != "")
                {
                    vouncher = value;
                }
                else
                {
                    vouncher = "unknown name";
                }
            }
        }
        public string iName
        {
            get
            {
                return itemname;
            }
            set
            {
                if (value != "")
                {
                    itemname = value;
                }
                else
                {
                    itemname = "unknown name";
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
                if (value >=1)
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
                if (value >= 1)
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
                if (value >= 1)
                {
                    qty = value;
                }
                else
                {
                    
                }
            }
        }
        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value >= 1)
                {
                    amount = value;
                }
                else
                {

                }
            }
        }
        //public int Subtot
        //{
        //    get
        //    {
        //        return subtot;
        //    }
        //    set
        //    {
        //        if (value >= 1)
        //        {
        //            subtot = value;
        //        }
        //        else
        //        {

        //        }
        //    }
        //}

        //public int Ta
        //{
        //    get
        //    {
        //        return ta;
        //    }
        //    set
        //    {
        //        if (value >= 1)
        //        {
        //            ta = value;
        //        }
        //        else
        //        {

        //        }
        //    }
        //}
        //public int Tot
        //{
        //    get
        //    {
        //        return tot;
        //    }
        //    set
        //    {
        //        if (value >= 1)
        //        {
        //            tot = value;
        //        }
        //        else
        //        {

        //        }
        //    }
        //}

        //public int dIs
        //{
        //    get
        //    {
        //        return dis;
        //    }
        //    set
        //    {
        //        if (value >= 1)
        //        {
        //            dis = value;
        //        }
        //        else
        //        {

        //        }
        //    }
        //}

        //public int Pay
        //{
        //    get
        //    {
        //        return pay;
        //    }
        //    set
        //    {
        //        if (value >= 1)
        //        {
        //            pay = value;
        //        }
        //        else
        //        {

        //        }
        //    }
        //}

       
    }
}
