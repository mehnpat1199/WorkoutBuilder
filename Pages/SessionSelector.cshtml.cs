using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WorkoutApp.Pages
{
    public class SessionSelector : PageModel
    {
        [BindProperty]
        public string? Name { get; set; }

        [BindProperty]
        public List<string>? SelectedBodyParts { get; set; } 

        public void OnGet(string name)
        {
            Name = name ?? "Guest";
        }

        public IActionResult OnPost()
        {
            if (SelectedBodyParts != null && SelectedBodyParts.Count > 0)
            {
                // Pass the selected body parts to the next page
                return RedirectToPage("/TailoredPlan", new { name = Name, bodyParts = string.Join(",", SelectedBodyParts) });
            }

            // If no body parts are selected, stay on the same page
            ModelState.AddModelError(string.Empty, "Please select at least one body part.");
            return Page();
        }
    }
}
