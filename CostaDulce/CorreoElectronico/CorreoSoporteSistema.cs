using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaDulce.CorreoElectronico
{
    class CorreoSoporteSistema:MasterMailServices
    {
        public CorreoSoporteSistema()
        {
            senderMail = "soportecostadulce@gmail.com";
            password = "sweetShore-199";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
