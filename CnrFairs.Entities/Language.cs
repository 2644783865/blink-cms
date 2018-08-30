using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_Language")]
    public class Language
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(100), Required]
        public string Name { get; set; }
        [StringLength(20)]
        public string LanguageCulture { get; set; }
        [StringLength(2)]
        public string UniqueSeoCode { get; set; }
        [StringLength(50)]
        public string FlagImageFileName { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
    }
}
