using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalapp
{
    public class RentalPrice
    {
        public double rent_per_kilometer = 1;
        public double Kilometers = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kilometers"></param>
        /// <param name="rent_per_kilometer"></param>
        /// 
        public RentalPrice()
        {
            Kilometers = 0;
            rent_per_kilometer = 1;
        }


        public double CalculateRentalCost(double distance, double fuelCost)
        {
            double totalCost = (distance * rent_per_kilometer) + fuelCost;
            return totalCost;

        }
    }
}
