using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Features.LeaveTypeAllocation.Queries.GetAllLeaveAllocations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetail
{
    public class GetLeaveAllocationDetailQueryHandler : IRequestHandler<GetLeaveAllocationDetailQuery, LeaveAllocationDetailDto>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public GetLeaveAllocationDetailQueryHandler(IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _leaveAllocationRepository = leaveAllocationRepository ?? throw new ArgumentNullException(nameof(leaveAllocationRepository));
        }
        public async Task<LeaveAllocationDetailDto> Handle(GetLeaveAllocationDetailQuery request, CancellationToken cancellationToken)
        {
            //Query from database
            var leaveAllocation = await _leaveAllocationRepository.GetAsync();

            //Mapper
            var data = _mapper.Map<LeaveAllocationDetailDto>(leaveAllocation);
            //return

            return data;
        }
    }
}
