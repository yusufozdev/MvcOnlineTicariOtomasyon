using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductBrand { get; set; }

        public short ProductStock{ get; set; }
        public decimal ProductPurchasePrice { get; set; }
        public decimal ProductSalesPrice { get; set;}
        public bool IsStock { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string ProductImage { get; set; }

        public virtual Category Category { get; set; }
        public ICollection<SalesMovement> SalesMovements { get; set; }

    }
}