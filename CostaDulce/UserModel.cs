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
        //atributos de cada usuario en la BD
        private int id;
        private string loginName;
        private string pass;
        private string name;
        private string lastN;
        private string mail;

        public UserModel(int id, string loginName, string pass, string name, string lastN, string mail)
        {
            this.id = id;
            this.loginName = loginName;
            this.pass = pass;
            this.name = name;
            this.lastN = lastN;
            this.mail = mail;
        }
        public UserModel()
        {

        }

        public string editUsrProfile()
        {
            
            try
            {
            userData.editarPerfil(id,loginName,pass,name,lastN,mail);
            LoginUser(loginName, pass);
                return "Información actualizada con exito.";
            }catch(Exception ex)
            {
                return "Este nombre de usuario ya esta registrado, ingresa otro.";
            }
        }

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
