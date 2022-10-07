using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace enroute.Pages;

public class Youtubers
{
    public string name;
    private string chanelUrl;
    private string intro;
    private List<videoCategories> categories = new List<videoCategories>();
    public class videoCategories
    {
        public string title {get; set;}
        public string videoTitle {get; set;}
        public string videoSrc {get; set;}
        public string text {get; set;}
    }
    public Youtubers(
        string _name,
        string _chanelUrl,
        string _intro,
        List<videoCategories> _categories
        )
    {
        name = _name;
        chanelUrl = _chanelUrl;
        intro = _intro;
        categories = _categories;
    }
    public void setName(string _name) {name = _name;}
    public string getName() {return name;}
    public string getChanelUrl() {return chanelUrl;}
    public string getIntro() {return intro;}
    public List<videoCategories> getCategories() {return categories;}
    
}
