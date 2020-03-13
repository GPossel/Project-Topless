using Project_Topless.Model;
using Project_Topless.Service;
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
using System.Windows.Threading;

namespace Project_Topless
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //color palet link : https://coolors.co/e2dadb-4d7ea8-8db580-1b1b1e-808080 
            InitializeComponent();

            Test();

            lblTimeShowcase.Content = string.Format("{0:HH:mm:ss tt}", DateTime.Now); //set time once before .Show() avoid [Time] display.
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            //set the mainwindow in the static windows container (The static window container will create the other windows itself.
            AllWindowsContainer allWindows = AllWindowsContainer.GetInstance();
            AllWindowsContainer.mainWin = this;

            lblTodayShowcase.Content = "[Today] " + DateTime.Now.ToString("dd/MM/yy");

            DispatcherTimer minutesShower = new DispatcherTimer();
            minutesShower.Tick += MinutesShower_Tick;
            minutesShower.Interval = new TimeSpan(0, 0, 1); //every second. [h,m,s]
            minutesShower.Start();
        }

        public Ticket_Service ticket_Service = new Ticket_Service();
        private void Test()
        {
            Ticket ticket = ticket_Service.Get_Ticket("Test insert ticket");
            ticket_Service.Delete_One_Ticket(ticket.Id.ToString());
        }

        private void MinutesShower_Tick(object sender, EventArgs e)
        {
            lblTimeShowcase.Content = string.Format("{0:HH:mm:ss tt}", DateTime.Now); /*DateTime.Now.ToString("h:mm:ss tt");*/
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
