using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetail
{
    public class GetLeaveTypeDetailQueryHandler : IRequestHandler<GetLeaveTypeDetailQuery, LeaveTypeDetailDto>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypeDetailQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _leaveTypeRepository = leaveTypeRepository ?? throw new ArgumentNullException(nameof(leaveTypeRepository));
        }
        public async Task<LeaveTypeDetailDto> Handle(GetLeaveTypeDetailQuery request, CancellationToken cancellationToken)
        {
            var leaveTypeDetail = await _leaveTypeRepository.GetByIdAsync(request.Id);

            //verify that record exists
            if (leaveTypeDetail == null)
                throw new NotFoundException(nameof(LeaveType), request.Id);

            var data = _mapper.Map<LeaveTypeDetailDto>(leaveTypeDetail);

            return data;
        }
    }
}
