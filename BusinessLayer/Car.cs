using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Car
    {
        [Key]
        public string LicensePlate { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int Year { get; set; }
        
        public Person Owner { get; set; }

        private Car()
        {
        }

        public Car(string licenseplate, string make, string model, string color, int year)
        {
            LicensePlate = licenseplate;
            Make = make;
            Model = model;
            Color = color;
            Year = year;
        }

        public override string ToString()
        {
            return String.Format("License plate: {0}, Make: {1}, Model: {2}, Color: {3}, Year: {4}", LicensePlate, Make, Model, Color, Year);
        }
    }
}
