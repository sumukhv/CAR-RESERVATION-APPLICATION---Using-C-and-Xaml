using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace CarReservationApp
{
    /// <summary>
    /// Interaction logic for Driver_Info.xaml
    /// </summary>
    public partial class Driver_Info : Window
    {
        string SelectedCar;
        
        public Driver_Info(string carName)
        {
            InitializeComponent();
            SelectedCar = carName;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SizeToContent = SizeToContent.WidthAndHeight;

            Txt_FirstName.Text = App.logininfo.FirstName;
            Txt_LastName.Text =App.logininfo.LastName ;
            Txt_PhoneNo.Text =App.logininfo.ContactNo;
            Txt_Email.Text = App.logininfo.EmailAddress;
            Txt_CarName.Text = SelectedCar;
            Txt_Address.Text = App.logininfo.Address;
        }

        private void Btn_Save_Click(object sender, RoutedEventArgs e)
        {
            var bookedcar = new ReservedCar { FirstName = Txt_FirstName.Text, LastName = Txt_LastName.Text, ContactNo = Txt_PhoneNo.Text, Address = Txt_Address.Text, Email = Txt_Email.Text, CarName = Txt_CarName.Text };
            App.reservedCar.Add(bookedcar);
            MessageBox.Show("Your Booking is Confirmed....");
            this.Close();
            Mystorage.WriteXML<ObservableCollection<ReservedCar>>("ReservedCar.xml", App.reservedCar);
        }
    }
}
