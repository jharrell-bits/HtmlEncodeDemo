using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;

namespace HtmlEncodeDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            string userInput = Request.Form["userinput"].ToString();
            string encodedUserInput = HttpUtility.HtmlEncode(Request.Form["userinput"]);

            System.Diagnostics.Debug.WriteLine($"userInput: {userInput}");
            System.Diagnostics.Debug.WriteLine($"encodedUserInput: {encodedUserInput}");
        }
    }
}
