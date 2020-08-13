using System;
using System.Collections.Generic;
using System.Text;

namespace _7_4_Lab_Reality_TV_Show
{
    class AboveDeck : BaseApplication
    {
        private int yearsBoatingExperience;
        private string nationality;

        /*        yearsBoatingExperience
                nationality
        */

        public AboveDeck(string firstName, string lastName, string birthDate, string Address, string City,
            string State, int Zip, string phoneNumber, string Email,
            //bool applSubmitted, bool applAccepted,
            int yearsBoatingExperience, string nationality)
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
            this.yearsBoatingExperience = yearsBoatingExperience;
            this.nationality = nationality;
            
        }





        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You’ve been accepted to “Above Deck”");
        }


    }
}
