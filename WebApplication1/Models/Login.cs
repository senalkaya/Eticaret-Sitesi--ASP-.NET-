﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Login
    {
        [Required]
        [DisplayName ("Adı")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Parola")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}