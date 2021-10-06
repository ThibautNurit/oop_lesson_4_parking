using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    class CarParkCharge
    {
        public int minimumFee { get; set; }
        public int minimumHours { get; set; }
        public CarParkCharge(int _minimumFee = 2, int _minimumHours = 3)
        {
            Console.WriteLine("I am CarParkCharge");
            minimumFee = _minimumFee;
            minimumHours = _minimumHours;
        }
        public override string ToString()
        {
            return "CarParkCharge I am";
        }

        public int CalculateCharge(int hoursParked)
        {
            
            int calculateFee = hoursParked < minimumHours ? minimumFee : hoursParked * minimumFee;
            return hoursParked * minimumFee;
        }

    }
}
