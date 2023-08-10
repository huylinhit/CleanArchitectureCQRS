using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Commands.CreateLeaveAllocation
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public CreateLeaveAllocationCommandHandler(IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _leaveAllocationRepository = leaveAllocationRepository ?? throw new ArgumentNullException(nameof(leaveAllocationRepository));
        }
        public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            //Validation

            //Mapper
            var leaveAllocationCreate = _mapper.Map<Domain.LeaveAllocation>(request);

            //Add To Database

            await _leaveAllocationRepository.CreateAsync(leaveAllocationCreate);
            //return

            return leaveAllocationCreate.Id;
        }
    }
}
