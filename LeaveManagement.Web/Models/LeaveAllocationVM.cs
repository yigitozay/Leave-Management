using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]

        public int Id { get; set; }
        [Display(Name ="Number of days")]
        [Required]
        [Range(1,65, ErrorMessage ="Invalid Number Entered")]
        public int NumberOfDays { get; set; }
        [Required]
        [Display(Name =" Allocation Period")]
        public int period { get; set; } 
        public LeaveTypeVM? LeaveType { get; set; }
    }
}