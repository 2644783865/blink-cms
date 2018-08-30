using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_Topic")]
    public class Topic
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int EntityID { get; set; }
        [StringLength(255), Required]
        public string SystemName { get; set; }
        [StringLength(4000)]
        public string Title { get; set; }
        [StringLength(4000)]
        public string SubTitle { get; set; }
        [StringLength(4000)]
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        [DataType(DataType.Url)]
        public string ContentUrl { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        [StringLength(400)]
        public string MetaKeywords { get; set; }
        [StringLength(4000)]
        public string MetaDescription { get; set; }
        [StringLength(400)]
        public string MetaTitle { get; set; }

        public virtual Picture Picture { get; set; }
        public virtual Language Language { get; set; }
        public virtual Fair Fair { get; set; }
    }
}