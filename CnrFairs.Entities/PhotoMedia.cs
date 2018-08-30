using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_PhotoMedia")]
    public class PhotoMedia
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Image { get; set; }
        public string SourceImage { get; set; }
        [StringLength(255), Required]
        public string ImageAlt { get; set; }
        [DataType(DataType.Url)]
        public string ImageUrl { get; set; }
        [StringLength(400)]
        public string MetaKeywords { get; set; }
        [StringLength(4000)]
        public string MetaDescription { get; set; }
        [StringLength(400)]
        public string MetaTitle { get; set; }

        public virtual Fair Fair { get; set; }
    }
}
