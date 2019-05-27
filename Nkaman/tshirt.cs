using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkaman
{
    public class tshirt:product
    {
        public override string Basket()
        {
            //if tshirt is golfer multiply standard price by 30
            if (type.ToLower() == "golfer")
            {
                switch (size.ToUpper())
                {
                    case "S":
                        totalp = 10 * 2;
                        break;
                    case "M":
                        totalp = 20 * 2;
                        break;
                    case "L":
                        totalp = 30 * 2;
                        break;
                    default:
                        totalp = 0;
                        break;
                }
            }
            else
            {
                //standard price 10,20,30
                switch (size.ToUpper())
                {
                    case "S":
                        totalp = 10;
                        break;
                    case "M":
                        totalp = 20;
                        break;
                    case "L":
                        totalp = 30;
                        break;
                    default:
                        totalp = 0;
                        break;
                }
            }
            return ("Tshirt Name is: " + this.Productname + "\nType is : " + this.type +"\nSize is: "+
                this.size + "\nCost Price is: " + totalp);
        }

    }
}
