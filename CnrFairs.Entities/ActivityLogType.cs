using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_ActivityLogType")]
    public class ActivityLogType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(100), Required]
        public string SystemKeyword { get; set; }
        [StringLength(200), Required]
        public string Name { get; set; }
        public bool Enabled { get; set; }
    }
}
