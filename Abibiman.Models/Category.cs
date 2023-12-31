﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abibiman.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        [MaxLength(30)]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order limit is between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
