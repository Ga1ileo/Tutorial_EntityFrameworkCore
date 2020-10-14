using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;


namespace Tutorial_EntityFrameworkCore.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student()
        {
            StudentId = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
    }
}