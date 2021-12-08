using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaDulce
{
    class UserModel
    {
        UserData userData = new UserData();
        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user,pass);
        }
        public string recuperaCont(string userRequesting)
        {
            return userData.recoverPassword(userRequesting);
        }
        
    }
}
