
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {

        public int  Id { get; set; }
        [Required(ErrorMessage ="Bu Alan bo� b�rak�lamaz")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Bu Alan bo� b�rak�lamaz")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Bu Alan bo� b�rak�lamaz")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Bu Alan bo� b�rak�lamaz")]
        public Boolean? WillAttend { get; set; }
        
    }
}