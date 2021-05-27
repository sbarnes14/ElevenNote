﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }

        [Display(Name="Stuart Barnes")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTimeOffset CreateUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
