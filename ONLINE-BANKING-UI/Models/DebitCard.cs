using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_BANKING_UI.Models
{
    public class DebitCard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [MaxLength(30)]
        public string CardNumber { get; set; }
        [MaxLength(50)]
        public string CardHolder { get; set; }
        
        public int ExpirationMM { get; set; }
  

        public int ExpirationYY { get; set; }
       
        public int CVV { get; set; }
    }
}
