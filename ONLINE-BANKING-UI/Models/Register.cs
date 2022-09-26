﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_BANKING_UI.Models
{
    public class Register
    {
        [Key]
        public int Userid { get; set; }
        [MaxLength(30)]
        public string Firstname { get; set; }
        [MaxLength(30)]
        public string Lastname { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(12)]
        public string Mobilenumber { get; set; }
        [MaxLength(10)]
        public string Gender { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }
        [MaxLength(30)]
        public string Repassword { get; set; }

        public DateTime MemberSince { get; set; }
    }
}
