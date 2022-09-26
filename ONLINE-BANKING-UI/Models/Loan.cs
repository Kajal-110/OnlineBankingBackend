using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_BANKING_UI.Models
{
    public class Loan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        [MaxLength(40)]
        public string name { get; set; }
        [MaxLength(40)]
        public string email { get; set; }
        [MaxLength(40)]
        public string number { get; set; }
        
        public int amount { get; set; }
        [MaxLength(40)]
        public string pincode { get; set; }
        [MaxLength(40)]
        public string city { get; set; }
        //[MaxLength(40)]
        public string Adharnumber { get; set; }

        [MaxLength(40)]
        public string Pannumber { get; set; }

        public int Salary { get; set; }
    }
}
