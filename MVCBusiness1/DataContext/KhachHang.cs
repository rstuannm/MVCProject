namespace MVCBusiness1.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(10)]
        public string username { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        [StringLength(10)]
        public string name { get; set; }

        [StringLength(10)]
        public string mobile { get; set; }

        [StringLength(10)]
        public string email { get; set; }

        public bool? sex { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(10)]
        public string adress { get; set; }
    }
}
