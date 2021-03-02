using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registration.Models
{
    public class ImageDbCondext : DbContext 
    {
        public ImageDbCondext(DbContextOptions<ImageDbCondext> options) : base(options)
        {

        }

        public DbSet<Images> RegImage { get; set; }
        public DbSet<MasterGender> MasterGender { get; set; }
        public DbSet<MasterPosition> MasterPosition { get; set; }
    }
}
