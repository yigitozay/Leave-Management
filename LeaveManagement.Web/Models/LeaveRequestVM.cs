﻿using LeaveManagement.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestVM: LeaveRequestCreateVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type")]

        public LeaveType LeaveType { get; set; }
        [Display(Name = "Date Requested")]
        public DateTime DateRequested { get; set; }

        public bool?Approved { get; set; }

        public bool Cancelled { get; set; }
    }
}
