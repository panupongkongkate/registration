using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace registration.Models
{
    public partial class MasterGender
    {
        public MasterGender()
        {
            Images = new HashSet<Images>();
        }

        [Key]
        public int GenderId { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<Images> Images { get; set; }
    }
}
