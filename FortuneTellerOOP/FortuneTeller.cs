using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerOOP
{
    class FortuneTeller
    {
        ///fields
        private string firstName;
        private string lastName;
        private int age;
        private int birthMonth;
        private string color;
        private int siblings;
        private int health;

        /// Properties
        public string GetFirstName
        {
            get { return this.firstName; }
            set { this.firstName = value;}
        }

        public string GetLastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int GetAge
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public int GetBirthMonth
        {
            get { return this.birthMonth; }
            set { this.birthMonth = value; }
        }
        public string GetColor
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public int GetSiblings
        {
            get { return this.siblings; }
            set { this.siblings = value; }
        }

        public int GetHealth
        {
            get { return this.health; }
            set { this.health = value; }
        }

        ///Constructors
        public FortuneTeller()
        {
            //default constructor
        }

        public FortuneTeller(string firstName, string lastName, int age, int birthMonth, string color, int siblings)
        {
            this.GetFirstName = firstName;
            this.GetLastName = lastName;
            this.GetAge = age;
            this.GetBirthMonth = birthMonth;
            this.GetColor = color;
            this.GetSiblings = siblings;
        }

        // Methods
        public string GetRetirement()
        {
            if ((age % 2) == 0)
            {
                return "10 years";

            }
            else
            {
                return "5 years";

            }

        }

        public void GetHelp()
        { 
                Console.WriteLine("Here is the list of available colors");
                Console.WriteLine();
                Console.WriteLine("              Red                   ");
                Console.WriteLine("              Orange                ");
                Console.WriteLine("              Yellow                ");
                Console.WriteLine("              Green                 ");
                Console.WriteLine("              Blue                  ");
                Console.WriteLine("              Indigo                ");
                Console.WriteLine("              Violet                ");
                Console.WriteLine("Please eneter your favorite color ");


                Tic();

        }
        public string GetVacationHome()
        {
            return "empty";
        }

        public string GetTransportation()
        {
            return "empty";
        }

        public string GetMoneyInBank()
        {
            return "empty";
        }

        public string GetFortune()
        {
            return "empty";
        }

        public void Tic()
        {

            GetHealth = GetHealth - 20;
            Console.WriteLine("Your Health is " + GetHealth);
            if (GetHealth <= 40)
            {
                Console.WriteLine("Would you like to restore your health?");
                string input = Console.ReadLine().ToLower();
                if (input == "yes")
                {
                    GetHealth = 100;
                }
                else if (GetHealth < 20)
                {
                    Console.WriteLine("Health has automatically been restored...");
                    GetHealth = 100;
                }



            }
            else
            {
                GetHealth = GetHealth - 20;
            }




        }



    }

}
