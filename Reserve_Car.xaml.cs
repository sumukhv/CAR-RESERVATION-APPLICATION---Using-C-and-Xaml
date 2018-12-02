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
    /// Interaction logic for Reserve_Car.xaml
    /// </summary>
    public partial class Reserve_Car : Window
    {
        public ObservableCollection<CarDetails> cardetails;
        public Reserve_Car(String pickloc, String choosecar, String transmission)
        {
            InitializeComponent();
            cardetails = Mystorage.ReadXML<ObservableCollection<CarDetails>>("carDetails.xml");

            TBx_PickLoc.Text = pickloc;
            TBx_ChooseCar.Text = choosecar;
            TBx_TransmissionType.Text = transmission;
            foreach(var carName in cardetails)
            {
                if(carName.CarNameAndType==choosecar)
                {
                    TBx_Price.Text = carName.Price.ToString();
                    break;
                }
            }
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // Driver_Info win3 = new Driver_Info();
            //win3.Show();
            //this.Close();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SizeToContent = SizeToContent.WidthAndHeight;
        }
    }
}
