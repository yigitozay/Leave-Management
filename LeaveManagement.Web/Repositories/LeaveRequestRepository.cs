using AutoMapper;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly ApplicationDbContext context;

        public LeaveRequestRepository(ApplicationDbContext context,IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<Employee> userManager, ILeaveAllocationRepository leaveAllocationRepository) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
            this.leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);

            var leaveRequest = mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested= DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;
            await AddAsync(leaveRequest);


        }

        public async Task<List<LeaveRequest>> GetAllAsync(string employeeId)
        {
            return  await context.LeaveRequests.Where(q => q.RequestingEmployeeId == employeeId).ToListAsync();
        }

        public async Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            var allocations = (await leaveAllocationRepository.GetEmployeeAllocations(user.Id)).LeaveAllocations;
            var requests = mapper.Map<List<LeaveRequestVM>>(await GetAllAsync(user.Id));
            var model = new EmployeeLeaveRequestViewVM(allocations, requests);
            return model;
        }
    }
}
