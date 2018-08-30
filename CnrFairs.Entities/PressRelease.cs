using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_PressRelease")]
    public class PressRelease
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int EntityID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Body { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), ScaffoldColumn(false), Required]
        public DateTime EditedTime { get; set; }
        public int Priority { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string MetaKeywords { get; set; }
        [StringLength(4000)]
        public string MetaDescription { get; set; }
        [StringLength(400)]
        public string MetaTitle { get; set; }

        public virtual Fair Fair { get; set; }
        public virtual Language Language { get; set; }
    }
}
