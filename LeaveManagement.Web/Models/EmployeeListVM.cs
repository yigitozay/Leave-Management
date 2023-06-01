using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }
        [Display(Name = "First Name")]

        public string Firstname { get; set; }
        [Display(Name = "Last Name")]

        public string Lastname { get; set; }

        [Display(Name = "E-mail address")]
        public string Email { get; set; }
        [Display(Name = "Date joined")]

        public string DateJoined { get; set; }
    }
}
