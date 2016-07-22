using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace EF_Example
{
    public class Employee
    {
        public Employee()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [MinLength(3, ErrorMessage = "Length must bemore than 3 characters")]
        [MaxLength (100, ErrorMessage = "Length must be less than 100 characters")]
        [Required]
        public string FirstName { get; set; }

        [MinLength(3, ErrorMessage = "Length must bemore than 3 characters")]
        [MaxLength(100, ErrorMessage = "Length must be less than 100 characters")]
        [Required]
        public string LastName { get; set; }

        [Required]
        public double Salary { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Birthdate { get; set; }

        public virtual Employee Manager { get; set; }

        [Required]
        public virtual Position Position { get; set; }

        [Required]
        public virtual Department Department { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}{7}Birthdate: {2}{7}Position: {3}{7}"));
        }
    }
}