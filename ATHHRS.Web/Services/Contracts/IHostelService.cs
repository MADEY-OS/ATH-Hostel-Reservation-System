using ATHHRS.Web.ViewModels;

namespace ATHHRS.Web.Services.Contracts
{
    public interface IHostelService
    {
        Task<IEnumerable<HostelViewModel>> GetHostels();
        Task<HostelViewModel> GetHostel(int id);
    }
}
