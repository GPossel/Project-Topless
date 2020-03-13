using Project_Topless.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Topless.DAL;

namespace Project_Topless.Service
{
    public class Login_Service
    {
        Login_DAO login_db = new Login_DAO();

        public List<User> GetAllUsers()
        {
            List<User> users = login_db.Get_All_Users_Db();

            return users;
        }

        public User GetUser(string userName)
        {
            User user = login_db.Get_User_Db(userName);

            return user;
        }
    }
}
