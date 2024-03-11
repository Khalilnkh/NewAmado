﻿using System.ComponentModel.DataAnnotations;

namespace Amado.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
