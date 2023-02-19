﻿using System.ComponentModel.DataAnnotations;

namespace ChildrenGift.Models.FormRequest
{
    public class GiftFormRequest
    {
        [StringLength(255, MinimumLength = 4)]
        public string Name { get; set; }
        [Required]
        public int ChildId { get; set; }
    }
}
