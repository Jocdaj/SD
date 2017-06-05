using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace DataAccess
{
    public class UserRepository : ConnectionClass
    {
        public void addUser(string username, string password, int roleId)
        {
            User u = new User();
            u.Username = username;
            u.Password = password;
            u.RoleId = roleId;

            entities.Users.Add(u);
            entities.SaveChanges();
        }
        public User getUser(int id)
        {
            return entities.Users.SingleOrDefault(x => x.UserId == id);

        }
        public bool checkIfUserIdExists(int userId)
        {
            int count = entities.Users.Where(x => x.UserId.Equals(userId)).Count();

            if (count < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkIfUsernameExists(string username)
        {
            int count = entities.Users.Where(x => x.Username.Equals(username)).Count();

            if (count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool login(string userName, string password)
        {
            return entities.Users.SingleOrDefault(x => x.Username.Equals(userName) && x.Password.Equals(password)) != null;
        }
        public User getSingleAccount(string userName)
        {
            return entities.Users.SingleOrDefault(e => e.Username.Equals(userName));
        }

        public User GetUserByID(int userId)
        {
            return entities.Users.SingleOrDefault(u => u.UserId == userId);
        }
        
    }
}
