using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF_Core_Lec02
{
    internal class Attendee
    {
        [Key]
        public int AttendeeId { get; set; }
        [MaxLength(150)]
        public string FullName { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(150)]
        public string Street { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(100)]
        public string Country { get; set; }
        [MaxLength(20)]
        [Column("ZipCode")]
        public string PostalCode { get; set; }
        [NotMapped]
        public string FullAddress
        {
            get
            {
                return $"{Street}, {City}, {Country}, {PostalCode}";
            }
        }

        public Badge Key { get; set; }

    }
}
