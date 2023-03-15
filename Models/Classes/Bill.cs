using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string BillSerialNumber { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string BillRowNumber { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string BillTaxAdministration { get; set; }

        public DateTime BillDateOfIssue { get; set; }

        public DateTime BillTimeOfIssue { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string BillSender { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string BillRecipient { get; set;}

        public ICollection<BillComponent> BillComponents { get; set; }

    }
}