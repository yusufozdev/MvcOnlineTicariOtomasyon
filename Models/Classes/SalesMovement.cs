using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class SalesMovement
    {
        [Key]
        public int SalesMovementId { get; set; }
        public DateTime SalesMovementDate { get; set; }
        public int SalesMovementCount { get; set; }
        public decimal SalesMovementCost { get; set; }
        public decimal SalesMovementTotal { get; set; }
        public Product Product { get; set; }
        public Current Current { get; set; }
        public Employee Employee { get; set; }


    }
}