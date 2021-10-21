using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BirthDateCalculations
{
    class FamilyMembers
    {
        public enum WeekDay { Monday =1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        private string _firstName;
        public string FirstName 
        {
            get { return _firstName; }
            set
            {
                char firstNameCase = char.Parse(value.Substring(0));

                if (Char.IsUpper(firstNameCase))
                {
                    _firstName = value;
                }
                else
                {
                    throw new Exception("first name must contain a capital letter!");
                }

            }
        }

        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        private string _email { get; set; }
        public string email 
        {
            get { return _email; }
            set
            {
                string pattern = null;
                pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

                if (Regex.IsMatch("feedback@net-informations.com", pattern))
                {
                    _email = value;
                }
                else
                {
                    throw new Exception("Not a valid Email address ");
                }
            }
        }
        public FamilyMembers() 
        {
            //initializer
        }
    }
}
