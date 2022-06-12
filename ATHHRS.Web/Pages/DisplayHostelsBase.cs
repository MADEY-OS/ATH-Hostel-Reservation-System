using ATHHRS.Web.ViewModels;
using Microsoft.AspNetCore.Components;

namespace ATHHRS.Web.Components
{
    public class DisplayHostelsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<HostelViewModel> Hostels { get; set; }
    }
}
