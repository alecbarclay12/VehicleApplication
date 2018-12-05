using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VehicleRentalapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Vehicle> vehicles;

        public MainWindow()
        {
            InitializeComponent();

            vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle("Ford", "T812", 2014, "AX12WD", 1000, 2.5,"2/12/2018"));
            vehicles.Add(new Vehicle("Toyota", "T54E3", 2008, "TX12WN", 31000, 5.5,"2/12/2018"));

            listViewVehicles.ItemsSource = vehicles;


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Vehicle ve = (Vehicle)listViewVehicles.SelectedItem;
            if (ve != null && tbJourney.Text != null)
            {
                ve.AddJourney(Convert.ToDouble(tbJourney.Text));





            }
            ObservableCollection<Vehicle> observable = new ObservableCollection<Vehicle>(vehicles);
            listViewVehicles.ItemsSource = observable;
        }

        private void btnAddFuel_Click(object sender, RoutedEventArgs e)
        {
            Vehicle ve = (Vehicle)listViewVehicles.SelectedItem;

            if (ve != null && txtFuelCost != null && txtLitres != null)
            {
                ve.FuelPurchase.PurchaseFuel(Convert.ToDouble(tbAddFuelbyLitre.Text), (Convert.ToDouble(tbAddFuelbyPrice.Text)));

                txtLitres.Text = ve.FuelPurchase.Litre.ToString();
                txtFuelCost.Text = ve.FuelPurchase.Costs.ToString();





            }
        }

      

        private void ListViewVehicles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Vehicle ve = (Vehicle)listViewVehicles.SelectedItem;
            if (ve != null)
            {
                tbManufacturer.Text = ve.Manufacturer.ToString();
                tbModel.Text = ve.Model.ToString();
                tbYear.Text = ve.MakeYear.ToString();
                tbRegoNumber.Text = ve.RegistrationNumber.ToString();
                tbOdometer.Text = ve.OdometerReading.ToString();
                tbTankCapacity.Text = ve.TankCapacity.ToString();
                tbLastServiceDate.Text = ve.OdometerReadingDate.ToString();
                


            }
        }

        private void Btn_Add_service_km_Click(object sender, RoutedEventArgs e)
        {
            Vehicle ve = (Vehicle)listViewVehicles.SelectedItem;

            if (tbLastserviceOdometerkm != null)
            {
                txtLastServiceKm.Text = ve.OdometerReading.ToString();
            }
        }
    }
}
