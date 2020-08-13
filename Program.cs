using System;

namespace _8_5_Lab_Reality_TV_Show
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DreamHH dreamApplicant = new DreamHH("Omar", "Smith", "2/4/1975", "111 Bravo Way", "Los Angeles",
                "California", 90001, "888-233-1234", "omar.smith@hotmail.com", 
                "Full Stack Web Developer", "$100,000", "6 months", 3, 2);
            dreamApplicant.Submit();
            dreamApplicant.Accept();
            ParIsland parisApplicant = new ParIsland("Patti", "Johnson", "5/4/1994", "211 Love Rd",
                "Los Angeles", "California", 90001, "988-444-1234", "patti.johnson @gmail.com",
                "Female", "Carl", 2);
            parisApplicant.Submit();
            parisApplicant.Accept();
            AboveDeck abovedeckApplicant = new AboveDeck("Captian", "Lee", "7/12/1964", "311 Bravo Way",
                "Los Angeles", "California", 90001, "711-333-1234", "captian@gmail.com", 
                20, "American");
            abovedeckApplicant.Submit();
            abovedeckApplicant.Accept();

        }
    }
}
