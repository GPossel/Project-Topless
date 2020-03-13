using Project_Topless.Model;
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

namespace Project_Topless
{
    /// <summary>
    /// Interaction logic for UserManagementScreen.xaml
    /// </summary>
    public partial class UserManagementScreen : Window
    {
        public class MyItem
        {
            //all test
            public int Id { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int TicketsCount { get; set; }
        }

        public UserManagementScreen()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            //test
            ListView lvU = this.LvUserManagement;
            for (int i = 0; i < 120; i++)
            {
                lvU.Items.Add(new MyItem { Id = 1, Email = "testmail@live.nl", FirstName = "Piece of tekst", LastName = "Piece of tekst", TicketsCount = 4 });
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItemSender = (MenuItem)sender;

            MenuNavigationHandler.GoToScreen(menuItemSender, this);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
