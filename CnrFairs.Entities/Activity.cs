using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_Activity")]
    public class Activity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(4000), Required]
        public int EntityID { get; set; }
        public string Title { get; set; }
        [StringLength(4000), Required]
        public string ShortDescription { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public string Image { get; set; }
        [StringLength(255), Required]
        public string ImageAlt { get; set; }
        [DataType(DataType.Url)]
        public string ImageUrl { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), ScaffoldColumn(false), Required]
        public DateTime AddedTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), ScaffoldColumn(false), Required]
        public DateTime EditedTime { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsDisplay { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(400)]
        public string MetaKeywords { get; set; }
        [StringLength(4000)]
        public string MetaDescription { get; set; }
        [StringLength(400)]
        public string MetaTitle { get; set; }

        public virtual Fair Fair { get; set; }
        public virtual Language Language { get; set; }
        public List<ActivityInstructor> ActivityInstructors { get; set; }
    }
}
