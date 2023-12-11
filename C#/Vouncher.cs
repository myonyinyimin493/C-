using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Vouncher
    {
        string vouncher;
        int subtot;
        int ta;
        int tot;
        int dis;
        int pay;

        public string VOU
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
        public int Subtot
        {
            get
            {
                return subtot;
            }
            set
            {
                if (value >= 1)
                {
                    subtot = value;
                }
                else
                {

                }
            }
        }

        public int Ta
        {
            get
            {
                return ta;
            }
            set
            {
                if (value >= 1)
                {
                    ta = value;
                }
                else
                {

                }
            }
        }
        public int Tot
        {
            get
            {
                return tot;
            }
            set
            {
                if (value >= 1)
                {
                    tot = value;
                }
                else
                {

                }
            }
        }

        public int dIs
        {
            get
            {
                return dis;
            }
            set
            {
                if (value >= 0)
                {
                    dis = value;
                }
                else
                {

                }
            }
        }

        public int Pay
        {
            get
            {
                return pay;
            }
            set
            {
                if (value >= 1)
                {
                    pay = value;
                }
                else
                {

                }
            }
        }
    }
}
