using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class BillComponent
    {
        [Key]
        public int BillComponentsID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string BillComponentsDescription { get; set; }

        public int BillComponentsQuantity { get; set; }
        public int BillComponentsAmount { get; set; }
        public int BillComponentsTotal { get; set; }
        public Bill Bill { get; set; }



    }
}