﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UserLogins
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public UserLogins()
        {

        }
    }
}
