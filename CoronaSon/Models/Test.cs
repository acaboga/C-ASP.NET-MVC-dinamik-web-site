namespace CoronaSon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Test")]
    public partial class Test
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        [StringLength(50)]
        public string Durum { get; set; }

        [StringLength(50)]
        public string Pozitif { get; set; }

        [StringLength(50)]
        public string Negatif { get; set; }
    }
}
