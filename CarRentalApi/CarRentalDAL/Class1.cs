using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalDAL
{
    public class Class1
    {
        public static void test()
        {
            CarRentalEntities1 carRentalEntities1 = new CarRentalEntities1();
            carRentalEntities1.Rentals.Add(null);
            }
    }
}
