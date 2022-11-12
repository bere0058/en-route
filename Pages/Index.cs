using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace enroute.Pages;

public class Youtubers
{
    public string name { get; set; }
    public string chanelUrl { get; set; }
    public string intro { get; set; }
    public class videoCategories
    {
        public string title { get; set; }
        public string videoTitle { get; set; }
        public string videoSrc { get; set; }
        public string text { get; set; }
    }
    public List<videoCategories> categories = new List<videoCategories>();
}
