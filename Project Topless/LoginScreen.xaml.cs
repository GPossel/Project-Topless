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
using System.Windows.Shapes;
using Project_Topless.Model;
using Project_Topless.Service;

namespace Project_Topless
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Login_Service login_service;

        public Window1()
        {
            InitializeComponent();
            login_service = new Login_Service();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            User currentUser = new User();

            List<User> users = login_service.GetAllUsers();

            foreach (User u in users)
            {
                if (txtUsrName.Text == u.userName)
                {
                    currentUser = u;
                }
            }

            if (txtUsrName.Text.ToLower() == currentUser.userName && txtPassWord.Text == currentUser.password)
            {
                MessageBox.Show("Welcome " + currentUser.userName.ToUpper());
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
            
        }
    }
}
