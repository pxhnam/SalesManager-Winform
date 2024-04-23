namespace PR_SalesManager.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillDetail
    {
        [Key]
        public int IDBillDetails { get; set; }

        public int IDProduct { get; set; }

        public int IDBill { get; set; }

        public double Price { get; set; }

        public int Amount { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Product Product { get; set; }
    }
}
