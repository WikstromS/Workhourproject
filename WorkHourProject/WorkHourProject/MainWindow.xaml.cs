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
using System.Data;
using System.Data.SQLite;
using System.Data.Common;

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
            string userName = UsernameTextbox.Text;
            string password = PasswordTextBox.Password;

            SQLiteConnection db = new SQLiteConnection("Data Source =|DataDirectory|testi.db;FailifMissing=True");
            db.Open();

            using (SQLiteCommand com = db.CreateCommand())
            {

                com.CommandText = "select * from USER where USERNAME = '" + userName + "'and PASSWORD='" + password + "'";
                using (IDataReader dr = com.ExecuteReader())
                {
                    bool verification = dr.Read();
                    if (verification)
                    {
                        if (userName == "admin" && password == "admin")
                        {
                            AdminWin win1 = new AdminWin();
                            win1.Show();
                            this.Close();
                        }
                        else
                        {
                            UserWin win2 = new UserWin();
                            win2.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        PasswordTextBox.Clear();
                        UsernameTextbox.Clear();
                        MessageBox.Show("Invalid username or password");
                    }
                    dr.Close();
                }
            }
        }
                
                

                public static bool AddUser(string username, string password)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source =|DataDirectory|testi.db;FailifMissing=True");
            using (SQLiteCommand com = new SQLiteCommand("INSERT INTO USER VALUES (@username, @password)", con))
            {
                //Add the input as parameters to avoid sql-injections
                com.Parameters.AddWithValue("@username", username);
                com.Parameters.AddWithValue("@password", password);

                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
                
            }

        }

        
    

