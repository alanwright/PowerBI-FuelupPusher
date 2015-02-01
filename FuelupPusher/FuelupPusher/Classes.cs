using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelupPusher
{
    public class Fuelup
    {
        public double Miles { get; set; }
        public double Gallons { get; set; }
        public double PricePerGallon { get; set; }
        public DateTime FuelupDate { get; set; }
        public double Mpg
        {
            get
            {
                return Miles / Gallons;
            }
        }
        public double TotalCost
        {
            get
            {
                return Gallons * PricePerGallon;
            }
        }
    }
}
