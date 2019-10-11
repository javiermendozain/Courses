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
    public class EditModel : PageModel
    {
        private readonly ICoursesProvider coursesProvider;

        // Marked as BindProperty for use link bidirectional 
        [BindProperty]
        public Course Course { get; set; }

        public EditModel(ICoursesProvider coursesProvider)
        {
            this.coursesProvider = coursesProvider;
        }
        public async Task<IActionResult> OnGet(int? id)
        {
            // Create a new course if it don't receive id
            if (id == null)
            {
                Course = new Course();
            }
            else
            {
                // Getting a course for edit on form
                var course = await coursesProvider.GetAsync(id.Value);
                if (course != null)
                {
                    Course = course;
                }
            }
            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            // Validate the form
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Id is 0, if it's creating a new course
            if (Course.Id == 0)
            {
                // Add the course at the course list
                var result = await coursesProvider.AddAsync(Course);

                // IsSuccess return true or false depending if the course  did update
                if (result.IsSuccess)
                {
                    return RedirectToPage("Courses");
                }

                return Page();
            }
            else
            {
                // Return true or false depending if the course  did update
                var result = await coursesProvider.UpdateAsync(Course.Id, Course);

                if (result)
                {
                    return RedirectToPage("Courses");
                }
            }

            return Page();
        }
    }
}