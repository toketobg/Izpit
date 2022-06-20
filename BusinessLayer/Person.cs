using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Person
    {
        [Key]
        public string SSN { get; set; }

        [Required]
        public string FName { get; set; }

        [Required]
        public string LName { get; set; }

        [Required]
        public string DateOfBirth { get; set; }

        public List<Car> Cars { get; set; }

        private Person()
        {
        }
        
        public Person(string ssn, string fname, string lname, string dob)
        {
            SSN = ssn;
            FName = fname;
            LName = lname;
            DateOfBirth = dob;
        }
        public override string ToString()
        {
            return String.Format("SSN: {0}, FName: {1}, LName: {2}, DoB: {3}", SSN, FName, LName, DateOfBirth);
        }
    }
}
