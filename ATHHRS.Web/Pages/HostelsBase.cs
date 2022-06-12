using ATHHRS.Web.Services.Contracts;
using ATHHRS.Web.ViewModels;
using Microsoft.AspNetCore.Components;

namespace ATHHRS.Web.Pages
{
    public class HostelsBase : ComponentBase
    {
        [Inject]
        public IHostelService HostelService{ get; set; }
        public IEnumerable<HostelViewModel> Hostels { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Hostels = await HostelService.GetHostels();
        }
    }
}
