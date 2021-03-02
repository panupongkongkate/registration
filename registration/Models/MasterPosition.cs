using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace registration.Models
{
    public partial class MasterPosition
    {
        public MasterPosition()
        {
            Images = new HashSet<Images>();
        }

        [Key]
        public int PositionId { get; set; }
        public string PositionName { get; set; }

        public virtual ICollection<Images> Images { get; set; }
    }
}
