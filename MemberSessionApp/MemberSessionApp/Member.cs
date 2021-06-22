using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSessionApp
{
    public class Member
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string Address { get; set; }

        public string PostCode { get; set; }

        public string ContactNum { get; set; }

        public string EmergencyNum { get; set; }

        public DateTime startYear { get; set; }

        public string GetFullName()
        {
            return FirstName + LastName;
        }

    }
}
