using ATHHRS.Web.Services.Contracts;
using ATHHRS.Web.ViewModels;
using Microsoft.AspNetCore.Components;

namespace ATHHRS.Web.Pages
{
    public class HostelDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IHostelService HostelService { get; set; }

        public HostelViewModel Hostel { get; set; }

        public string ErrorMessage { get; set; }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                Hostel = await HostelService.GetHostel(Id);
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
