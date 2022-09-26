using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ONLINE_BANKING_UI.Models
{
    public class CreatePassword
    {
        [Key]
        public int id { get; set; }
        [MaxLength(30)]
        public string CerdHolderName { get; set; }
        [MaxLength(30)]
        public string EnterPassword{ get; set; }
        public DateTime MemberSince { get; set; }
    }
}
