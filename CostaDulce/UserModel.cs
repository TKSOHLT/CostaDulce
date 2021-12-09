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
        private int iduser;
        private string loginName;
        private string pass;
        private string Name;
        private string LastN;
        private string mail;

        public UserModel(int iduser, string loginName, string pass, string name, string lastN, string mail)
        {
            this.iduser = iduser;
            this.loginName = loginName;
            this.pass = pass;
            this.Name = name;
            this.LastN = lastN;
            this.mail = mail;
        }
        public UserModel()
        {

        }

        public string editUsrProfile()
        {
            
            try
            {
            userData.editarPerfil(iduser,loginName,pass,Name,LastN,mail);
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
