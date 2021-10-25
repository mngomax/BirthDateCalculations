using System;
using System.Collections.Generic;
using System.Text;

namespace BirthDateCalculations
{
    public class CalculateClass
    {
        public string workOutDay(string DOB= "01/04/1984")
        {
            int DOBLength = DOB.Length;
            var year = DOB.Substring(DOBLength, (DOBLength - 4));

            string weekDay = FamilyMembers.WeekDay.Thursday.ToString();
            return weekDay;
        }
    }
}
