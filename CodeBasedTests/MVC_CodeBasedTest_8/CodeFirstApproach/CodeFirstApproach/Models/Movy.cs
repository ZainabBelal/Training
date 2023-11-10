namespace CodeFirstApproach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mid { get; set; }

        [StringLength(30)]
        public string mname { get; set; }

        public DateTime? dateofrelease { get; set; }
    }
}
