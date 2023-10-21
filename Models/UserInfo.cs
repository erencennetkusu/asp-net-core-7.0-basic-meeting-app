
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {

        public int  Id { get; set; }
        [Required(ErrorMessage ="Bu Alan boþ býrakýlamaz")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Bu Alan boþ býrakýlamaz")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Bu Alan boþ býrakýlamaz")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Bu Alan boþ býrakýlamaz")]
        public Boolean? WillAttend { get; set; }
        
    }
}