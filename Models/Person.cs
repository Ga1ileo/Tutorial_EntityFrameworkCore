using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tutorial_EntityFrameworkCore.Models
{
    public class Person
    {
        [Key]
        public int personId { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

        public Person()
        {
            personId = 0;
            name = string.Empty;
            lastName = string.Empty;
        }
    }
}