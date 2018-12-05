using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalapp
{
    public class Service
    {
        public static int SERVICE_KILOMETER_LIMIT = 10000;

        public double lastServiceOdometerKm { get; set; }
        public int serviceCount { get; set; }
        public DateTime lastServiceDate = DateTime.Now;


        //Returns the last service

        public double getLastServiceOdometerKm()
        {
            return this.lastServiceOdometerKm;
        }

        public void RecordService (double distance)
        {
            this.lastServiceOdometerKm = distance;
            this.serviceCount++;
            this.lastServiceDate = DateTime.Now;
        }

        public int getServiceCount()
        {
            return this.serviceCount;
        }

        public int getTotalScheduledServices()
        {
            return (int)Math.Floor(lastServiceOdometerKm / SERVICE_KILOMETER_LIMIT);
        }
    }     
}
