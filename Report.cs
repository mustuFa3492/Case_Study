namespace Case_Study
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Report")]
    public partial class Report
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Date { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Product_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Quantity { get; set; }

        [Key]
        [Column(Order = 3)]
        public double Price { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string dr_cr { get; set; }
    }
}
