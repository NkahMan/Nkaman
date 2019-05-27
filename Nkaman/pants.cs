using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkaman
{
    public class pants:product
    {
        // function to calculate price
        public override string Basket()
        {
            //if pants is formal add 30 to the normal price
            if (type.ToLower() == "formal")
            {
                switch (size.ToUpper())
                {
                    case "S":
                        totalp = 10 + 30;
                        break;
                    case "M":
                        totalp = 20 + 30;
                        break;
                    case "L":
                        totalp = 30 + 30;
                        break;
                    default:
                        totalp = 0;
                        break;
                }
            }
            else
            {
                //standard price 10, 20, 30
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
            return ("Pants Name is: " + this.Productname + "\nType is : " + this.type + "\nSize is: " +
                this.size + "\nCost Price is: " + totalp);
        }
    }
}
