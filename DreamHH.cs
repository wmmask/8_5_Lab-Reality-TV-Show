using System;
using System.Collections.Generic;
using System.Text;

namespace _8_5_Lab_Reality_TV_Show
{
    class DreamHH : BaseApplication  //The House Hunter Class
    {

        private string jobTitle;
        private string currentAnnualIncome;
        private string whenLookingToBuy;
        private int numberBedrooms;
        private int numberBathrooms;

        /*        jobTitle;
                currentAnnualIncome;
                whenLookingToBuy;
                numberBedrooms;
                numberBathrooms;
        */

        public  DreamHH(string firstName, string lastName, string birthDate, string Address, string City,
                            string State, int Zip, string phoneNumber, string Email,
                            //bool applSubmitted, bool applAccepted,
                            string jobtitle, string currentAnnualIncome, string whenLookingToBuy, 
                            int numberBedrooms, int numberBathrooms)
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
            this.jobTitle = jobTitle;
            this.currentAnnualIncome = currentAnnualIncome;
            this.whenLookingToBuy = whenLookingToBuy;
            this.numberBedrooms = numberBedrooms;
            this.numberBathrooms = numberBathrooms;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine(@"You’ve been accepted to “Dream House Hunters”");
        }
         


    }
}
