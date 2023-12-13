using DM_SHEET.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DM_SHEET.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext database;

        public IndexModel(AppDbContext database)
        {
            this.database = database;
        }

        public void OnGet()
        {

        }
    }
}