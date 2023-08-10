using HR.LeaveManagement.Application.Features.LeaveTypeAllocation.Queries.GetAllLeaveAllocations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetail
{
    public record GetLeaveAllocationDetailQuery : IRequest<LeaveAllocationDetailDto>
    {
    }
}
