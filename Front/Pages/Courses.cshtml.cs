using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaCursos.Interfaces;
using ListaCursos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ListaCursos.Pages
{
    public class CoursesModel : PageModel
    {
        private readonly ICoursesProvider coursesProvider;

        public List<Course> Courses { get; set; }
        
        // Marked as BindProperty for use link bidirectional and support of get/post 
        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }

        public CoursesModel(ICoursesProvider coursesProvider)
        {
            this.coursesProvider = coursesProvider;
        }

        public async Task<IActionResult> OnGet()
        {
            // Validate than Search isn't null or empty
            if (!string.IsNullOrWhiteSpace(Search))
            {
                // Getting searches by name
                var results = await coursesProvider.SearchAsync(Search);
                if (results != null)
                {
                    Courses = new List<Course>(results);
                }
            }
            else
            {
                // Getting all courses on the list
                var results = await coursesProvider.GetAllAsync();
                if (results != null)
                {
                    Courses = new List<Course>(results);
                }
            }

            return Page();
        }
    }
}