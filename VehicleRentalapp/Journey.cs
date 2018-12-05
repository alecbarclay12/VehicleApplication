using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalapp
{
   public class Journey
    {
        private double kilometers;



        /**
         * Class constructor
         */
        public Journey()
        {
            this.kilometers = 0;
        }

        /// <summary>
        /// Appends the distance parameter to Kilometers
        /// </summary>
        /// <param name="kilometers"></param>
        public void AddKilometers(double kilometers)
        {
            this.kilometers += kilometers;
        }



        /**
         * Getter method for total Kilometers traveled in this journey.
         * @return {@link #kilometers}
         */
        public double GetKilometers()
        {
            return kilometers;
        }
    }

}
