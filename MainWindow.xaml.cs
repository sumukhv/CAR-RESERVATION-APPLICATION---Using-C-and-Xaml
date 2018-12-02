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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarReservationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn_LoginClick(object sender, RoutedEventArgs e)
        {

           
          
               foreach(var person in App.personinfo)
                {
                    if(person.EmailAddress == Txt_Email.Text && person.Password==TBx_Password.Password)
                    {
                        App.logininfo = person;
                        MessageBox.Show("Login Successful");
                        break;
                    }
                }

            if (App.logininfo.EmailAddress != null)
            {
                Dashboard win5 = new Dashboard();
                win5.Show();
                Close();
            } else
            {
                MessageBox.Show("Incorrect email or password");
                return;
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

            Sign_Up win2 = new Sign_Up();
            win2.Show();
            //Close();


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          App.personinfo = Mystorage.ReadXML<ObservableCollection<RegistrationInfo>>("RegistrationInfo.xml");
        }
    }

    
}
