using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HR.LeaveManagement.Application.Features.LeaveTypeAllocation.Queries.GetAllLeaveAllocations;


public record GetLeaveAllocationsQuery : IRequest<List<LeaveAllocationDto>>
{
    // Properties and methods specific to GetLeaveAllocationsQuery
}