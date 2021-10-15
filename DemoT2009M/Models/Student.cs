using System;

namespace DemoT2009M.Models
{
    public class Student
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public int StudentStatus Status { get; set; }
        
        public override string ToString()
        {
            return $"Rollnumber {RollNumber}, Fullname {FullName}, Email {Email}, Phone {Phone}, Created At {CreatedAt}";
           
        }
    }
}
        