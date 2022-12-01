using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace enroute.Pages;

public class Youtuber : PageModel
{
    public Youtubers youtuber { get; set; }
    public YoutubersModel youtubersList = new YoutubersModel();

    public IActionResult OnGet(string ytName)
    {
        youtuber = youtubersList.getYoutubers().Find(yt => yt.Name == ytName);

        if (youtuber == null)
        {
            return NotFound();
        }

        return Page();
    }
}