using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Project_Topless.Model
{
    public class MenuNavigationHandler
    {
        public static void GoToScreen(MenuItem clickedItem, Window currentScreen)
        {
            AllWindowsContainer windowContainer = AllWindowsContainer.GetInstance();

            if(clickedItem.Name == "toDashBoard")
            {
                //bring to dashboard if dashboard not open yet.
                if(currentScreen.GetType() != typeof(MainWindow))
                {
                    OpenAndHideWindows(AllWindowsContainer.mainWin, currentScreen);
                }
            }
            else if(clickedItem.Name == "toIndicentManagement")
            {
                if (currentScreen.GetType() != typeof(IncidentManagementScreen))
                {
                    OpenAndHideWindows(AllWindowsContainer.incidentManagementScreen, currentScreen);
                }
            }
            else
            {
                //to user Management screen.
                if (currentScreen.GetType() != typeof(UserManagementScreen))
                {
                    OpenAndHideWindows(AllWindowsContainer.userManagementScreen, currentScreen);
                }
            }

            void OpenAndHideWindows(Window targetOpen, Window targetClose)
            {
                targetOpen.Show();
                FindTargetScreen(targetClose).Hide();
            }

            Window FindTargetScreen(Window target)
            {
                //finds the current screen the WindowsContainer
                if (target.GetType() == typeof(MainWindow)) return AllWindowsContainer.mainWin;
                else if (target.GetType() == typeof(UserManagementScreen)) return AllWindowsContainer.userManagementScreen;
                else return AllWindowsContainer.incidentManagementScreen;
            }
        }
    }
}
