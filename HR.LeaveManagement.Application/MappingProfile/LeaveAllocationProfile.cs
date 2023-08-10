using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetail;
using HR.LeaveManagement.Application.Features.LeaveTypeAllocation.Queries.GetAllLeaveAllocations;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.MappingProfile
{
    public class LeaveAllocationProfile : Profile
    {
        public LeaveAllocationProfile()
        {
            CreateMap<LeaveAllocationDto, LeaveAllocation>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDetailDto>();
            //CreateMap<CreateLeaveTypeCommand, LeaveType>();
            //CreateMap<UpdateLeaveTypeCommand, LeaveType>();
            //CreateMap<DeleteLeaveTypeCommand, LeaveType>();
        }
    }
}
