using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnrFairs.Entities
{
    [Table("cnrexpo_SliderTitleLocation")]
    public class SliderTitleLocation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(10)]
        public string TitleLocationX { get; set; }
        [StringLength(10)]
        public string TitleLocationY { get; set; }
        [StringLength(10)]
        public string HeightOffSet { get; set; }
        [StringLength(10)]
        public string VerticalOffSet { get; set; }

        public virtual Slider Slider { get; set; }
    }
}
