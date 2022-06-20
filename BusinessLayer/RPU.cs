using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RPU
    {
        [Key]
        public string RPUID { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public int RPUNumber { get; set; }

        public Person Head { get; set; }
        
        private RPU() 
        {
        }

        public RPU(string city, int rpunumber)
        {
            RPUID = Guid.NewGuid().ToString();
            City = city;
            RPUNumber = rpunumber;
        }
        public RPU(string id, string city, int rpunumber)
        {
            RPUID = id;
            City = city;
            RPUNumber = rpunumber;
        }
        public override string ToString()
        {
            return String.Format("RPUID: {0}, City: {1}, RPUNumber: {2}", RPUID, City, RPUNumber);
        }
    }
}
