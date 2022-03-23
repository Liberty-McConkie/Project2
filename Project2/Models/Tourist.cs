using System;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Tourist
    {
        [Key]
        public int TouristId { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        [Range(1, 16, ErrorMessage = "The max group size is 16 people")]
        public int SizeOfGroup { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public DateTime AppointmentStart { get; set; }


    }
}
