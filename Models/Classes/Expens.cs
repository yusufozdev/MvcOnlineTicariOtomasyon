using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Expens
    {
        [Key]
        public int ExpensId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string ExpensName { get; set; }

        public DateTime ExpensDate { get; set; }
        public decimal ExpensAmounts { get; set; }
    }
}