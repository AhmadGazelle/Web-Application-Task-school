namespace SchoolWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tetcher")]
    public partial class Tetcher
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TetcherName { get; set; }

        [StringLength(50)]
        public string Major { get; set; }
    }
}
