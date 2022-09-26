using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_BANKING_UI.Models
{
    public class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(10)]
        public string Password { get; set; }
        [MaxLength(10)]
        public  string mobileNo  { get; set; }
        //public int Amount { get; set; }
    }
}
