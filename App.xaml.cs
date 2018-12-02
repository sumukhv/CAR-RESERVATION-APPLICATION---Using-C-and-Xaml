using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CarReservationApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ObservableCollection<RegistrationInfo> personinfo;
        public static ObservableCollection<ReservedCar> reservedCar;
    
        public static RegistrationInfo logininfo = null;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            personinfo = Mystorage.ReadXML<ObservableCollection<RegistrationInfo>>("RegistrationInfo.xml");
            reservedCar = Mystorage.ReadXML<ObservableCollection<ReservedCar>>("ReservedCar.xml");

            if(personinfo==null)
            {
                personinfo = new ObservableCollection<RegistrationInfo>();
            }
            if(reservedCar==null)
            {
                reservedCar = new ObservableCollection<ReservedCar>();
            }
            MainWindow main = new MainWindow();
            //main.Show();
        }
    }
   
}
