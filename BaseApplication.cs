using System;
using System.Collections.Generic;
using System.Text;

namespace _7_4_Lab_Reality_TV_Show
{
    class BaseApplication
    {
        protected string firstName;
        protected string lastName;
        protected string birthDate;  //Need to verify format enterred for birthday
        protected string Address;
        protected string City;
        protected string State;
        protected int Zip;
        protected string phoneNumber; //Need to verify format enterred for birthday
        protected string Email; //Need to verify format enterred for birthday
        protected bool applSubmitted;
        protected bool applAccepted;


/*        public void BaseApplication()
        {
            this.firstName = firstName;
            this.lastName;
            this.birthDate;
            this.Address;
            this.City;
            this.State;
            this.Zip;
            this.phoneNumber;
            this.Email;
            this.applSubmitted;
            this.applAccepted;
        }*/

        public void Submit()
        {
            applSubmitted = true;
            Console.WriteLine("Application has been submitted.");
        }

        public virtual void Accept()
        {
            applAccepted = true;
            Console.WriteLine("Application Accepted");
        }










    }
}
