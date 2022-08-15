using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AAAA.Models
{
   
    [Table("Account")]
    public partial class Account
    {
        [Column("id")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? LastName { get; set; }
        public int? Pin { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Email { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? City { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? Balance { get; set; }
    }
}
