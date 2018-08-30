using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_ContactForm")]
    public class ContactForm
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(255), Required]
        public string FullName { get; set; }
        [DataType(DataType.EmailAddress), Required]
        public string MailAdress { get; set; }
        [StringLength(10), DataType(DataType.PhoneNumber), Required]
        public string Phone { get; set; }
        [Required]
        public string Message { get; set; }

        public virtual Fair Fair { get; set; }
    }
}
