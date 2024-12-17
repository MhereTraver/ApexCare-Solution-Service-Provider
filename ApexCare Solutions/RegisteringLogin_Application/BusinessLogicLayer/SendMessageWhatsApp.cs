using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteringLogin_Application.BusinessLogicLayer
{
    abstract class SendMessageWhatsApp
    {
        private int technicianNumber;
        private string message;


        public SendMessageWhatsApp() { }


        public SendMessageWhatsApp(int technicianNumber, string message)
        {
            this.technicianNumber = technicianNumber;
            this.message = message;
        }

        public int TechnicianNumber { get => technicianNumber; set => technicianNumber = value; }
        public string Message { get => message; set => message = value; }

        public abstract void SendWhatsAppMessage(string technicianNumber, string message);
    }
}
