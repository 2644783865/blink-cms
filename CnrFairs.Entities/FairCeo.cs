using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_FairCeo")]
    public class FairCeo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int EntityID { get; set; }
        [StringLength(400), Required]
        public string MetaTitle { get; set; }
        [StringLength(4000), Required]
        public string MetaDescription { get; set; }
        [StringLength(400), Required]
        public string MetaKeywords { get; set; }

        public virtual Fair Fair { get; set; }
        public virtual Language Language { get; set; }
    }
}
