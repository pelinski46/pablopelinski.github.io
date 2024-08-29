
using System.Net.Http.Json;

namespace Portfolio.Pages;

public partial class FetchData
{
    List<HistoryItem>? repositories;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        repositories = await Http.GetFromJsonAsync<List<HistoryItem>>("https://api.github.com/users/pelinski46/repos");
    }

    class HistoryItem
    {
        public string Full_Name { get; set; }
        public string Description { get; set; }
        public string HTML_URL { get; set; }


    }
}
