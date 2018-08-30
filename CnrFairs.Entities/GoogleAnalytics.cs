using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_GoogleAnalytics")]
    public class GoogleAnalytics
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Script1 { get; set; }
        public string Script2 { get; set; }
        public string Script3 { get; set; }
        public string Script4 { get; set; }

        public virtual Fair Fair { get; set; }
    }
}
