using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace registration.Models
{
    public partial class Images
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("ชื่อ")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("นามสกุล")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required]
        public string Password { get; set; }

        [DisplayName("ConfirmPassword")]
        [Required]
        public string ConfirmPassword { get; set; }

        [DisplayName("วันเกิด")]
        [Required]
        public DateTime? Dateofbirth { get; set; }

        [DisplayName("เบอร์โทร")]
        [Required]
        public string Phonenumber { get; set; }

        [DisplayName("ความสูง")]
        [Required]
        public int Height { get; set; }

        [DisplayName("น้ำหนัก")]
        [Required]
        public int Weight { get; set; }

        [DisplayName("เพศ")]
        [Required]
        public int? GenderId { get; set; }

        [DisplayName("อาชีพ")]
        [Required]
        public int? PositionId { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("รูปภาพ")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }


        public virtual MasterGender Gender { get; set; }
        public virtual MasterPosition Position { get; set; }
    }
}
