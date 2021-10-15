using System;
using DemoT2009M.Models;
namespace DemoT2009M
{
    public enum StudentStatus
    {
        Active = 1,  
        Deactive = 0, 
        Deleted = -1
      
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var st = new Student
            {
                RollNumber = ("T2009"),
                FullName = "Ngo Viet Hoang",
                Birthday = DateTime.Parse("2002-05-30"),
                Email = "hoang@gmail.com",
                Phone = "0912345678",
                CreatedAt = DateTime.Now,
                Status = StudentStatus.Active
            };
            Console.WriteLine(st.ToString());
            
           
        }
    }
}