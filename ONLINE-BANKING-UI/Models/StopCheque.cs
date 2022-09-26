using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_BANKING_UI.Models
{
    public class StopCheque
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        [MaxLength(30)]
        public string AccountHolderName { get; set; }
        [MaxLength(30)]
        public string PartyName { get; set; }
        [MaxLength(30)]
        public string TypeOfBankAccount { get; set; }
        [MaxLength(30)]
        public string AccountNumber { get; set; }
        [MaxLength(30)]
        public string CheckNumber { get; set; }
        [MaxLength(30)]
        public string Amount { get; set; }
        [MaxLength(50)]
        public string CheckStopPaymentReason { get; set; }
        public DateTime DateOnTheCheck { get; set; }

    }
}
