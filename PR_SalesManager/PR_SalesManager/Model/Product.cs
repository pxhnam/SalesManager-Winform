namespace PR_SalesManager.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        [Key]
        public int IDProduct { get; set; }

        [Required]
        [StringLength(50)]
        public string NameProduct { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Pic { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Describe { get; set; }

        public int IDType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
