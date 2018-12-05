using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalapp
{
    public class Vehicle
    {
        private string manufacturer;
        private string model;
        private int makeYear;
        private string registrationNumber;
        private double odometerReading;
        private double tankCapacity;
        private string lastServiceOdometerDate;
        public  FuelPurchase fuelpurchase;
        private Journey journey;
        private Service service;
        private RentalPrice rental;





        /**
         * Class constructor specifying name of make (manufacturer), model and year
         * of make.
      /// *<param name="Manufacturer"></param>
    /// <param name="Model"></param>
    /// <param name="MakeYear"></param>
    /// <param name="RegistrationNumber"></param>
    /// <param name="OdometerReading"></param>
     <param name="TankCapacity"></param>
     <param name="lastServiceOdometerDate"></param>
         */


        public Vehicle(string manufacturer, string model, int makeYear, string registrationNumber, double odometerReading, double tankCapacity, string lastServiceOdometerDate)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.makeYear = makeYear;
            this.registrationNumber = registrationNumber;
            this.odometerReading = odometerReading;
            this.tankCapacity = tankCapacity;
            this.lastServiceOdometerDate= lastServiceOdometerDate;
            fuelpurchase = new FuelPurchase();
            journey = new Journey();
            service = new Service();
            rental = new RentalPrice();


        }

        public string OdometerReadingDate
        {
            get { return lastServiceOdometerDate; }
            set { lastServiceOdometerDate = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int MakeYear
        {
            get { return makeYear; }
            set { makeYear = value; }
        }

        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        public double OdometerReading
        {
            get { return odometerReading; }
            set { odometerReading = value; }
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set { tankCapacity = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// 

        public FuelPurchase FuelPurchase
        {
            get { return fuelpurchase; }
            set { fuelpurchase = value; }
        }




        public Journey Journey
        {
            get { return journey; }
            set { journey = value; }
        }

        public Service Service { get; set; }


        public RentalPrice Rental { get; set; }

        public void AddJourney(double km)
        {
            journey.AddKilometers(km);
            odometerReading += km;
        }

        public void addFuel(double litres, double price)
        {
            FuelPurchase.PurchaseFuel(litres, price);
        }

    }
}
