using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_FairDetail")]
    public class FairDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int EntityID { get; set; }
        [StringLength(255), Required]
        public string FairName { get; set; }
        [StringLength(255), Required]
        public string Subject { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [StringLength(255)]
        public string Organizator { get; set; }
        [StringLength(255)]
        public string Hall { get; set; }
        [StringLength(255)]
        public string Place { get; set; }

        public virtual Fair Fair { get; set; }
        public virtual Language Language { get; set; }

    }
}
