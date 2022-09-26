using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_BANKING_UI.Models
{
    public class Transferamount
    {

        [Key]
        public int id { get; set; }

        public string AccountHolderName { get; set; }
        public int Totalamount { get; set; }
    }
}
