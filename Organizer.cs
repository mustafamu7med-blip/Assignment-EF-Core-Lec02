using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF_Core_Lec02
{
    [Table("EventOrganizers")]
    internal class Organizer 
    {
        [Key]
        public int OrganizerId { get; set; }
        [MaxLength(100)]
        public string OrganizerName { get; set; }
        [MaxLength(150)]
        [AllowNull]
        public string CompanyName { get; set; }

        public int ProfileId { get; set; }
        public OrganizerProfile Profile { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
