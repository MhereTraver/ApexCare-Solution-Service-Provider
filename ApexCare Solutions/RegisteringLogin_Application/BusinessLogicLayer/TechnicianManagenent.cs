using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteringLogin_Application.BusinessLogicLayer
{
    abstract class TechnicianManagenent
    {
        private int technicianID;
        private string technicianSurname;
        private string firstName;
        private string email;
        private string jobDescription;
        private string phoneNumber;
        private string employeeKey;
        private string employeeSecret;

        //Default Constructor
        public TechnicianManagenent() { }

        public TechnicianManagenent(int technicianID, string technicianSurname, string firstName, string email, string jobDescription, string phoneNumber, string employeeKey, string employeeSecret)
        {
            this.technicianID = technicianID;
            this.technicianSurname = technicianSurname;
            this.firstName = firstName;
            this.email = email;
            this.jobDescription = jobDescription;
            this.phoneNumber = phoneNumber;
            this.employeeKey = employeeKey;
            this.employeeSecret = employeeSecret;
        }

        public int TechnicianID { get => technicianID; set => technicianID = value; }
        public string TechnicianSurname { get => technicianSurname; set => technicianSurname = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Email { get => email; set => email = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string EmployeeKey { get => employeeKey; set => employeeKey = value; }
        public string EmployeeSecret { get => employeeSecret; set => employeeSecret = value; }

        public abstract void CreateTechnician(int technicianID, string technicianSurname, string firstName, string email, string jobDescription, string phoneNumber, string employeeKey, string employeeSecret);

        public abstract DataTable DisplayTechnician();

        public abstract void DeleteTechnician(int technicianID);

        public abstract void UpdateTechnician();

        public abstract DataTable SearchTechnicianInTheDB(int technicianID);


    }
}
