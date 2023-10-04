using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee {0} is required")] //   Attribute
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name should be minimun 4 character and maximum 50 charcter.")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Range(18, 125, ErrorMessage = "Age should be minimum 18 and maximum 125.")]
        public int Age { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string Phno { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
