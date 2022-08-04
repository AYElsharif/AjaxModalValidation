﻿using System.ComponentModel.DataAnnotations;

namespace AjaxModal.Models
{
    public class Contact
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}