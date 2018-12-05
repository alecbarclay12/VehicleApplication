using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalapp
{
    public class FuelPurchase
    {

        private double Litres;
        private double Cost;
     
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Litres"></param>
        /// <param name="Cost"></param>

        public FuelPurchase()
        {
            this.Cost += Cost;
            this.Litres += Litres;

            
            
        }

        //getter and setter method for Litres and cost

       public double Litre
        {
            get { return Litres; }
            set { Litres = value; }
        }
        
        public double Costs
        {
            get { return Cost; }
            set { Cost = value; }
        }

          


        public void PurchaseFuel(double amount, double price)
        {
            Litres += amount;
            Cost += price;
        }


    }
}
