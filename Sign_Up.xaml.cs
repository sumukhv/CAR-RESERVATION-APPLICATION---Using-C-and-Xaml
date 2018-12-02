using System;
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
    /// Interaction logic for Sign_Up.xaml
    /// </summary>
    public partial class Sign_Up : Window
    {
        ObservableCollection<RegistrationInfo> registeration;
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            registeration = Mystorage.ReadXML<ObservableCollection<RegistrationInfo>>("RegistrationInfo.xml");
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn_Signup_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win4 = new MainWindow();
            win4.Show();
            
            if(Txt_Password.Text==Txt_Confirm_Password.Text)
            {
                var register = new RegistrationInfo
                {
                    FirstName = Txt_FirstName.Text,
                    LastName = Txt_LastName.Text,
                    ContactNo = Txt_Contact.Text,
                    Address = Txt_Address.Text,
                    EmailAddress = Txt_Email.Text,
                    Password = Txt_Confirm_Password.Text
                };
                registeration.Add(register);
                MessageBox.Show("Registered successfully...!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password doesn't match");
            }
            
            Mystorage.WriteXML<ObservableCollection<RegistrationInfo>>("RegistrationInfo.xml", registeration );
        }

       
    }
}
