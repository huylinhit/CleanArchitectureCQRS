using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HR.LeaveManagement.Application.Features.LeaveTypeAllocation.Queries.GetAllLeaveAllocations;


public class GetLeaveAllocationsQueryHandler : IRequestHandler<GetLeaveAllocationsQuery, List<LeaveAllocationDto>>
{
    private readonly IMapper _mapper;
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;

    public GetLeaveAllocationsQueryHandler(IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _leaveAllocationRepository = leaveAllocationRepository;
    }
    public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationsQuery request, CancellationToken cancellationToken)
    {
        //get
        var leaveAllocations = await _leaveAllocationRepository.GetAsync();
        //validation

        //map
        var data = _mapper.Map<List<LeaveAllocationDto>>(leaveAllocations);

        //return
        return data;
    }
}

