using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_ExhibitorProfile")]
    public class ExhibitorProfile
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int EntityID { get; set; }
        [Required]
        public string Body { get; set; }

        public virtual Language Language { get; set; }
    }
}
