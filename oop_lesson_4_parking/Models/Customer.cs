using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    class Customer
    {

        public int hoursParked { get; set; }

        public string registration {get;set;}
        public Customer(int _hoursParked, string _registration)
        {
            Console.WriteLine("I am Customer");
            hoursParked = _hoursParked;
            registration = _registration;
        }
        public override string ToString()
        {
            return "Customer I am";
        }
    }
}
