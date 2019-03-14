namespace oatest1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        [Key]
        [StringLength(20)]
        public string uid { get; set; }

        [StringLength(50)]
        public string uname { get; set; }

        [StringLength(50)]
        public string password { get; set; }
    }
}
