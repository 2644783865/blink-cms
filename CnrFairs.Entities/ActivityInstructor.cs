using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_ActivityInstructor")]
    public class ActivityInstructor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int EntityID { get; set; }
        [StringLength(255), Required]
        public string FullName { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        [StringLength(250)]
        public string ImageAlt { get; set; }
        [DataType(DataType.Url)]
        public string ImageUrl { get; set; }
        public int DisplayOrder { get; set; }
        [StringLength(400)]
        public string MetaKeywords { get; set; }
        [StringLength(4000)]
        public string MetaDescription { get; set; }
        [StringLength(400)]
        public string MetaTitle { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Language Language { get; set; }
    }
}
