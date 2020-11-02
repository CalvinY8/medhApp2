using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolLibrary 
{
    public class Student {
        public string StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string BCITID { get; set; }
        [Required]
        public string MobileNo { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Option { get; set; }
        [Required]
        public string Set { get; set; }

    }
}

