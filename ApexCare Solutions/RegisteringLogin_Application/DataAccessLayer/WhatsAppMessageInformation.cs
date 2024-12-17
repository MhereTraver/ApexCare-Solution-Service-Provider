using RegisteringLogin_Application.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisteringLogin_Application.DataAccessLayer
{
    internal class WhatsAppMessageInformation : SendMessageWhatsApp
    {
        public override void SendWhatsAppMessage(string technicianNumber, string message)
        {
            try
            {
                if (technicianNumber == "")
                {
                    MessageBox.Show("Kindly add a Technician`s Phone number");

                    return;
                }
                else if (message == "")
                {
                    MessageBox.Show("Your message cannot be empty!!!");
                    return;
                }
                else if (technicianNumber.Length < 10)
                {
                    MessageBox.Show("Your Number is Short");
                    return;

                }
                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone" + technicianNumber +
                    "&text=" + " " + "PREMIER SERVICE SOLUTION⏳ \n \t " + " " + message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
