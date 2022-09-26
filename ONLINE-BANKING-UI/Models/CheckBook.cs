using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_BANKING_UI.Models
{
    public class CheckBook
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]

        public string AccountType { get; set; }
        [MaxLength(30)]

        public String Branch { get; set; }
        [MaxLength(30)]

        public string TheresholdLimit { get; set; }
        

        public string Checkbooks { get; set; }
        

        public string CheckLeaves { get; set; }
    }
}
