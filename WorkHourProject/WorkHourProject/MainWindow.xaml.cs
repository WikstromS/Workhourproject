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
using WorkHourProject;

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
            if(UsernameTextbox.Text == "admin" && PasswordTextBox.Text == "admin")
            {
                AdminWin win1 = new AdminWin();
                win1.Show();
                this.Close();
            }

            if(UsernameTextbox.Text == "vieras" && PasswordTextBox.Text == "vieras")
            {
                UserWin win2 = new UserWin();
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
