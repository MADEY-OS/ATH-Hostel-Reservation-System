using System.Net.Http.Json;
using ATHHRS.Web.Services.Contracts;
using ATHHRS.Web.ViewModels;

namespace ATHHRS.Web.Services
{
    public class HostelService : IHostelService
    {
        public readonly HttpClient _httpClient;
        public HostelService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<HostelViewModel>> GetHostels()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/hostel");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<HostelViewModel>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<HostelViewModel>>();

                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<HostelViewModel> GetHostel(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/hostel/{id}");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(HostelViewModel);
                    }

                    return await response.Content.ReadFromJsonAsync<HostelViewModel>();

                }
                var message = await response.Content.ReadAsStringAsync();

                throw new Exception(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}
