using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkaman
{
    public abstract class product
    {
        public string Productname;
        public string size;
        public string type;
        public double totalp;
        public abstract string Basket();
    }
}
