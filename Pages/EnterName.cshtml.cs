using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WorkoutApp.Pages
{
    public class NameModel : PageModel
    {
        [BindProperty]
        public string ?Name { get; set; }

        public void OnGet(string name)
        {
            Name = name;
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(Name))
            {

                return RedirectToPage("/SessionSelector", new { name = Name });
            }

            return Page();
        }
    }
}