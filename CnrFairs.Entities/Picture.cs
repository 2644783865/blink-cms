using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_Picture")]
    public class Picture
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string SeoFileName { get; set; }
        [StringLength(400)]
        public string Href { get; set; }
        [DataType(DataType.DateTime), Required]
        public DateTime UpdatedOnUtc { get; set; }
        [StringLength(255)]
        public string Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
