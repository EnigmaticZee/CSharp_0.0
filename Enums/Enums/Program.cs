using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    //Always best to set explicit values for the enums

    /*Because it's very likely that somewhere in your 
     * database, you might have a table that represents
     * this enum. So, you want to make sure that id's or
     * the values you assign to these enum members match
     * to the records you have in the database. If you 
     * rely on the automatic value assignment and sometime
     * in the future add a new member to this enum. The 
     * value of some of the existing member may change
     * andc may no longer match the record in the database.
     */
     //By default if you don't assign anything the first member
     //gets assigned a value of 0 and the next ones gets it 
     //incremented by 1
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            //Parsing - Getting a string and converting to a different type
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
