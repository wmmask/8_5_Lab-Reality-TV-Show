using System;
using System.Collections.Generic;
using System.Text;

namespace _7_4_Lab_Reality_TV_Show
{
    class ParIsland : BaseApplication
    {
        private string gender;
        private string nameSigOther;
        private int yearsDating;

        /*        gender;
                nameSigOther;
                yearsDating;
        */

        public ParIsland(string firstName, string lastName, string birthDate, string Address, string City,
                    string State, int Zip, string phoneNumber, string Email,
                    //bool applSubmitted, bool applAccepted,
                    string gender, string nameSigOther, int yearsDating)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.phoneNumber = phoneNumber;
            this.Email = Email;
            this.applSubmitted = applSubmitted;
            this.applAccepted = applAccepted;
            this.gender = gender;
            this.nameSigOther = nameSigOther;
            this.yearsDating = yearsDating;
            
        }



        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You’ve been accepted to “Paradise Island”");
        }



    }
}
