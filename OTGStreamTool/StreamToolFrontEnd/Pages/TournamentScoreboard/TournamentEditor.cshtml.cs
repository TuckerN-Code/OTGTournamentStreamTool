using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;

namespace StreamToolFrontEnd.Pages.TournamentScoreboard
{
    public class TournamentEditorModel : PageModel
    {
        public string P1Tag { get; set; }
        public void OnGet()
        {
            P1Tag = "Celsus";
            
        }
    }
}
