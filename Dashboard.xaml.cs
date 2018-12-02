using CarReservationApp;
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
    public partial class Dashboard : Window
    {
        /// <summary>
        /// Interaction logic for Dashboard.xaml
        /// </summary>

        public ObservableCollection<CarDetails> cardetails;

        public static List<String> PickupLocation;
        public static List<String> ChooseCar = new List<String>();
        public static List<String> TransmissionType;


        public Dashboard()
        {
            InitializeComponent();

            cardetails = Mystorage.ReadXML<ObservableCollection<CarDetails>>("carDetails.xml");

            if (cardetails == null)
            {
                cardetails = new ObservableCollection<CarDetails>();
            }

            PickupLocation = new List<String> { "Heidelberg", "Berlin", "Frankfurt", "Stuttgart" };


            foreach(var car in cardetails)
            {
                ChooseCar.Add(car.CarNameAndType);
            }
            TransmissionType = new List<String> { "Automatic", "Manual" };

          

        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
                SizeToContent = SizeToContent.WidthAndHeight;
                CBx_PickLoc.ItemsSource = PickupLocation;
                CBx_ChooseCar.ItemsSource = ChooseCar;
                CBx_TransmissionType.ItemsSource = TransmissionType;
                //Txt_Price.IsEnabled=false;
            
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(CBx_ChooseCar.SelectedValue.ToString()==null && CBx_PickLoc.SelectedValue.ToString()==null && CBx_DropLoc.SelectedValue.ToString()==null && CBx_TransmissionType.SelectedValue.ToString()==null )
            {
                MessageBox.Show("Please enter all the fields..");
                return;
            }
            else
            {
                Driver_Info person = new Driver_Info(CBx_ChooseCar.SelectedValue.ToString());
                person.Show();
            }
           
            //Reserve_Car win6 = new Reserve_Car(pickloc,choosecar,transmission);
            //win6.Show();
            //Close();
        }

        private void CBx_ChooseCar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach(var car in cardetails)
            {
                if(car.CarNameAndType== CBx_ChooseCar.SelectedValue.ToString())
                {
                    Txt_Price.IsEnabled = true;
                    Txt_Price.Text = car.Price.ToString();
                    break;
                }
            }
       
        }
    }
}


