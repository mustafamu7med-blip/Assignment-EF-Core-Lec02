using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF_Core_Lec02
{
    internal class Event
    {
        public int Id { get; set; }
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }

    }
}
