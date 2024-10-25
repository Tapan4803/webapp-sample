// Pages/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp_sample.Models;
using System.Collections.Generic;

namespace webapp_sample.Pages
{
    public class IndexModel : PageModel
    {
        public List<User> Users { get; set; }

        public void OnGet()
        {
            // Simulated user data; replace this with actual database retrieval later
            Users = new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
                new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
            };
        }
    }
}
