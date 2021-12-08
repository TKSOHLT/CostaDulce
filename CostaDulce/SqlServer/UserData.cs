using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CostaDulce
{
    class UserData:ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command =new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "SELECT *FROM Users where NombreUsuario=@user and Password =@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }


        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var command= new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT *FROM Users WHERE NombreUsuario=@User OR Correo=@mail";
                    command.Parameters.AddWithValue("@User", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                   

                    if (reader.Read())
                    {
                        string userName = reader.GetString(3) + " " + reader.GetString(4)+" ";
                        string userMail = reader.GetString(5);
                        string acountPass = reader.GetString(2);
                    /*    List<string> listmail = new List<string>();
                        foreach
                        listmail.Add(userMail);*/ //EN CASO DE TENER UNO O MAS DESTINATARIOS.
                        var mailService = new CorreoElectronico.CorreoSoporteSistema();
                        mailService.sendMail(
                            subject:"SistemaCostaDulce: Proceso de recuperación de contraseña",
                             body:  "Saludos, "+userName+"Haz solicitado recordar tu contraseña. \n" +
                             "Tu contraseña es->"+acountPass, recipentMail: new List<string> { userMail}
                            );
                        return "TU CONTRASEÑA FUE ENVIADA EXITOSAMENTE A TU \n CORREO PROPORCIONADO";
                    }
                    else
                    {
                        return "Lo siento, al parecer no hay una cuenta\n relacionada con el correo o contraseña proporcionados";
                    }
                }
            }
        }








    }
}
