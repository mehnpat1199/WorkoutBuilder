using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WorkoutApp.Pages
{
    public class TailoredPlanModel : PageModel
    {
        public string? Name { get; set; }
        public List<string> TailoredPlan { get; private set; } = new List<string>();

        public void OnGet(string name, string bodyParts)
        {
            Name = name;
            var selectedBodyParts = bodyParts.Split(',');

            foreach (var part in selectedBodyParts)
            {
                switch (part.ToLower())
                {
                    case "chest":
                        TailoredPlan.Add("Push-Ups");
                        TailoredPlan.Add("Bench Press");
                        break;
                    case "back":
                        TailoredPlan.Add("Pull-Ups");
                        TailoredPlan.Add("Deadlifts");
                        break;
                    case "legs":
                        TailoredPlan.Add("Squats");
                        TailoredPlan.Add("Lunges");
                        break;
                    case "biceps":
                        TailoredPlan.Add("Bicep Curls");
                        break;
                    case "triceps":
                        TailoredPlan.Add("Tricep Dips");
                        break;
                    case "glutes":
                        TailoredPlan.Add("Hip Thrusts");
                        break;
                    case "hamstrings":
                        TailoredPlan.Add("Romanian Deadlifts");
                        break;
                    case "quads":
                        TailoredPlan.Add("Leg Extensions");
                        break;
                }
            }
        }
    }
}
