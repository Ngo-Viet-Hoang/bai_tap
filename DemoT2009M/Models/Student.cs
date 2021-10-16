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
        public StudentStatus Status { get ; set; }

        public bool IsNewStudent()
        {
            return false;
        }

        public bool IsDeactive()
        {
            return Status == StudentStatus.Deactive;
        }
        
        public override string ToString()
        {
            return $"Rollnumber {RollNumber}, Fullname {FullName}, Email {Email}, Phone {Phone}, Created At {CreatedAt}";
           
        }
    }
}
        