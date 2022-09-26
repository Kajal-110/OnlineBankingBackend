using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_BANKING_UI.Models
{
    public class Depositeamount
    {

        [Key]
        public int id { get; set; }

        public int AccountNumber { get; set; }
        public int Amount { get; set; }
        public DateTime MemberSince { get; set; }
        public Account Account { get; set; }
    }
}
