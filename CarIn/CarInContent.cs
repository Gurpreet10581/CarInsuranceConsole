using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarIn
{
  
    public class CarInContent
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int TypeOfMembership { get; set; }

        public CarInContent() { }

        public CarInContent(int idNumber, string lastName, int age, DateTime enrollmentDate, int type)
        {
            Id = idNumber;
            LastName = lastName;
            Age = age;
            EnrollmentDate = enrollmentDate;
            TypeOfMembership = type;
        }



    }
}
