using System.ComponentModel.DataAnnotations;

namespace Winamacpowershow.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }

        [Required]
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:f}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date:")]
        public DateTime DatePublished { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
