using System;
using System.Collections.Generic;
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

namespace WorkHourProject
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

        private void UsernameTextBox_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
        private void PasswordTextBox_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if(UsernameTextbox.Text == "vieras" && PasswordTextBox.Text == "vieras")
            {
                Window win2 = new Window();
                win2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        
    }
}
