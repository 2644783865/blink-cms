using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_EmailAccount")]
   public class EmailAccount
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(255), Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(255), Required]
        public string DisplayName { get; set; }
        [StringLength(255), Required]
        public string Host { get; set; }
        public int Port { get; set; }
        [StringLength(255), Required]
        public string Username { get; set; }
        [StringLength(255), Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public bool EnableSsl { get; set; }
        public bool UseDefaultCredentials { get; set; }
    }
}
