using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoolEvents.Data.Entities
{
    public class Events
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public string UmgUrl { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/YYYY}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string GetEventImage()
        {
            if (!string.IsNullOrEmpty(UmgUrl))
            {
                return UmgUrl;
            }
            else
            {
                return "https://www.google.com/imgres?imgurl=https%3A%2F%2Fmedia.istockphoto.com%2Fid%2F978975308%2Fvector%2Fupcoming-events-neon-signs-vector-upcoming-events-design-template-neon-sign-light-banner-neon.jpg%3Fs%3D612x612%26w%3D0%26k%3D20%26c%3DVMCoJJda9L17HVkFOFB3fyDpjC4Qu2AsyYn3u4T4F4c%3D&tbnid=c_5o9TEeeAFTFM&vet=12ahUKEwjEzJv2vtH-AhUPy6QKHQVoAx8QMygCegUIARC7AQ..i&imgrefurl=https%3A%2F%2Fwww.istockphoto.com%2Fphotos%2Fupcoming-events&docid=V9V0H0SbIoVE1M&w=612&h=450&q=events%20pictures&ved=2ahUKEwjEzJv2vtH-AhUPy6QKHQVoAx8QMygCegUIARC7AQ";
            }
        }
    }
}
