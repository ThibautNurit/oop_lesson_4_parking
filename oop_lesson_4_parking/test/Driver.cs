using oop_lesson_4_parking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.test
{
    class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am Driver");
        }
        public void CreateObjects()
        {
            Customer cu = new Customer(1, "a");
            Customer cu2 = new Customer(2,"b");
            Customer cu3 = new Customer(3,"c");
            Customer cu4 = new Customer(4,"d");
            Customer cu5 = new Customer(5,"e");
            Customer cu6 = new Customer(20,"f");

            CarPark cp = new CarPark();

            cp.AddCustomer(cu);
            cp.AddCustomer(cu2);
            cp.AddCustomer(cu3);
            cp.AddCustomer(cu4);
            cp.AddCustomer(cu5);
            cp.AddCustomer(cu6);
            cp.CalculateCharges();


            CarParkCharge cpc = new CarParkCharge();

            Console.WriteLine(cu.ToString());
            Console.WriteLine(cp.ToString());
            Console.WriteLine(cpc.ToString());
        }
    }
}
