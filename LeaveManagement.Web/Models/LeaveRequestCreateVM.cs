using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestCreateVM 
    {
        [Required]
        [Display(Name ="Start Date")]
        public DateTime? StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]

        public DateTime? EndDate { get; set; }
        [Required]

        public int LeaveTypeId { get; set; }
        public  SelectList LeaveTypes { get; set; }
        [Display(Name = "Request Comments")]

        public string RequestComments { get; set; }

      
    }
}
