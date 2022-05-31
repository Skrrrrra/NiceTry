﻿using System;
using System.ComponentModel.DataAnnotations;

namespace NiceTry.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string name { get; set; }
        [Required(ErrorMessage ="Please enter your e-mail address")]
        [RegularExpression(".+\\@.+\\..", ErrorMessage = "Please enter your e-mail address")]
        public string email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string phone { get; set; }
        [Required(ErrorMessage ="Please specify whether you will attend")]
        public bool? willAttend { get; set; }
    }
}
