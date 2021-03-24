using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public bool Citizen { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int StaffID { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string NINo { get; set; }
        public string Gender { get; set; }
        public string StaffLastName { get; set; }
        public string StaffFirstName { get; set; }
    }
}