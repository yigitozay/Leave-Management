using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class AdminLeaveRequestViewVM
    {
        [Display(Name = "Total Number Of Requests")]
        public int TotalRequests { get; set; }  

        public int ApprovedRequests { get; set; }

        public int PendingRequests { get; set; }

        public int RejectedRequests { get; set; }

        public List<LeaveRequestVM> LeaveRequests { get; set; }

    }
}
