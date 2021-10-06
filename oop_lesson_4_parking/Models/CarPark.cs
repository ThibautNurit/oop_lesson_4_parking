using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    class CarPark
    {

        public List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge cpc = new CarParkCharge();

        public CarPark()
        {
            Console.WriteLine("I am CarPark");
        }

        public override string ToString()
        {
            return "CarPark I am";
        }

        public void CalculateCharges()
        {
            foreach(Customer c in listOfCustomers)
            {
                int calculatedCharges = cpc.CalculateCharge(c.hoursParked);
                Console.WriteLine($"Calculating charge for customer cost is : {calculatedCharges}");
            }
        }


    }
}
