using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_BANKING_UI.Models
{
    public class CreateAccount
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
        [MaxLength(30)]
        public string Address { get; set; }
        [MaxLength(10)]
        public string Dateofbirth { get; set; }
        public string MobileNo { get; set; }
        [MaxLength(8)]
        public string Gender { get; set; }

        public int Amount { get; set; }
    }
}
