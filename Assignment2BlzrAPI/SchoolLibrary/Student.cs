using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolLibrary 
{
    public class Student {
        public string StudentId { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Begin first name with capital and include only letters")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Begin last name with capital and include only letters")]
        public string LastName { get; set; }
        [Required]
        [StringLength(9)]
        [RegularExpression(@"^A+[0-9]*$", ErrorMessage = "Start ID with a capital letter followed by 8 digits")]
        public string BCITID { get; set; }
        [Required]
        [Phone]
        public string MobileNo { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Begin city name with capital and include only letters")]
        public string City { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Begin option name with capital and include only letters")]
        public string Option { get; set; }
        [Required]
        [StringLength(1)]
        [RegularExpression(@"[A-Z]", ErrorMessage = "Begin Set with capital and include only one letter")]
        public string Set { get; set; }

    }
}

