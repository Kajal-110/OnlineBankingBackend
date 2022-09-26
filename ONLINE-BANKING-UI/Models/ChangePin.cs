using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_BANKING_UI.Models
{
    public class ChangePin
    {
        [Key]
        public int id { get; set; }
        [MaxLength(4)]
        public string oldpassword { get; set; }
        [MaxLength(4)]
        public string enternewpassword { get; set; }
        [MaxLength(4)]
        public string confirmnewpassword { get; set; }
    }
}
