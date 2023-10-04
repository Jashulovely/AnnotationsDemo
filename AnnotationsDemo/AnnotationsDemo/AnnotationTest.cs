using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    internal class AnnotationTest
    {
        public void Annotation() {
            Employee emp = new Employee();
            emp.Name = "Jashu";
            emp.Age = 23;
            emp.Phno = "+919949976020";
            emp.Email="porsu.jaswanthkumar@gmail.com";
            ValidationContext validate = new ValidationContext(emp);
            List<ValidationResult> list = new List<ValidationResult>(); 
            bool valid = Validator.TryValidateObject(emp, validate, list, true);
            if (!valid)
            {
                foreach (ValidationResult result in list)
                {
                    Console.WriteLine(result.MemberNames.First(),Environment.NewLine);
                    Console.WriteLine(result.ErrorMessage,Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name : {0}", emp.Name);
                Console.WriteLine("Age : {0}", emp.Age);
                Console.WriteLine("Phno : {0}", emp.Phno);
                Console.WriteLine("Email : {0}", emp.Email);
            }
        }

    }
}
