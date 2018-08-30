using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_Employee")]
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int EntityID { get; set; }
        [StringLength(255), Required]
        public string FirstName { get; set; }
        [StringLength(255), Required]
        public string LastName { get; set; }
        [StringLength(255), Required]
        public string Title { get; set; }
        [StringLength(4), Required]
        public string ExternalNumber { get; set; }
        [DataType(DataType.EmailAddress), Required]
        public string MailAdress { get; set; }

        public virtual Language Language { get; set; }
    }
}
