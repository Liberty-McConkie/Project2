using System;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Userinfo
    {
        [Key]
        public int TouristId { get; set; }

        [Required]
        [Range(0, 16, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public string GroupName { get; set; }

        [Required]
        public int SizeOfGroup { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }


    }
}
