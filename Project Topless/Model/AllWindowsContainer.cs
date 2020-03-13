using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topless.Model
{
    public class AllWindowsContainer
    {
        private static AllWindowsContainer instance = new AllWindowsContainer();
        public static MainWindow mainWin;
        public static UserManagementScreen userManagementScreen = new UserManagementScreen();
        public static IncidentManagementScreen incidentManagementScreen = new IncidentManagementScreen();

        private AllWindowsContainer()
        {
            //disables creating another instance of this class.
        }

        public static AllWindowsContainer GetInstance()
        {
            if(AllWindowsContainer.instance == null)
            {
                AllWindowsContainer.instance = new AllWindowsContainer();
                return AllWindowsContainer.instance;
            }
            else return AllWindowsContainer.instance;
        }
    }
}
