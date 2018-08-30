using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_Fair")]
    public class Fair
    {
        [Key]
        public int SiteID { get; set; }
        [StringLength(250), Required]
        public String WebSite { get; set; }
        [Required]
        public Boolean IsActive { get; set; }
        [Required]
        public Boolean IsDeleted { get; set; }
    }
}
