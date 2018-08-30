using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_ActivityLog")]
    public class ActivityLog
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(4000), Required]
        public string Comment { get; set; }
        [DataType(DataType.DateTime), Required]
        public DateTime CreatedOnUtc { get; set; }
    }
}
