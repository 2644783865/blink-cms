using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_Slider")]
   public class Slider
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int EntityID { get; set; }

        [Required]
        public string Image { get; set; }
        [StringLength(255), Required]
        public string ImageAlt { get; set; }
        [DataType(DataType.Url)]
        public string ImageUrl { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [StringLength(10)]
        public string BackgroundColor { get; set; }

        public virtual Fair Fair { get; set; }
        public virtual Language Language { get; set; }
    }
}
