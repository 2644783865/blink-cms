using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_DepartmentWithEmployee")]
    public class DepartmentWithEmployee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public virtual Fair Fair { get; set; }
        public virtual Language Language { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Department Department { get; set; }
    }
}
