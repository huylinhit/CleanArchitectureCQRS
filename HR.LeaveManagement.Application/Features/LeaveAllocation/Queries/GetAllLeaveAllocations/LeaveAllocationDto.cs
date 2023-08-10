using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Features.LeaveTypeAllocation.Queries.GetAllLeaveAllocations
{
    public class LeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }

        public string EmployeeId { get; set; } = string.Empty;
    }
}
