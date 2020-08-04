using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hamilton.Models
{
    public class AddressBook
    {
        [Key]
        public int AddressBookId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName ="nvarchar(100)")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string SurName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Email { get; set; }

 
    }
}
