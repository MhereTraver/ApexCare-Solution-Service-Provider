using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteringLogin_Application.BusinessLogicLayer
{
    abstract class ClientManagement
    {
        private int id;
        private string name;
        private string surname;
        private string email;
        private string contract;
        private string phoneNumber;
        private string address;

        //Default Constructor
        public ClientManagement() { }
        public ClientManagement(int id, string name, string surname, string email, string contract, string phoneNumber, string address)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.contract = contract;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Contract { get => contract; set => contract = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }

        public abstract void insertDataIntoTheDatabase(int id, string name, string surname, string email, string contract, string phoneNumber, string address);

        public abstract DataTable DisplayCustomerDetails();

        public abstract void DeletingCustomerFromTheDatabase(int technicianID);

        public abstract void UpdateCustomerDataIntoTheDatabase(int id, string name, string surname, string email, string contract, string phoneNumber, string address);

        public abstract DataTable SearchCustomerDataFromTheDatabase(int technicianID);
    }
}
