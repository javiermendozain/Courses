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
    public class VideosModel : PageModel
    {

        private readonly IVideosProvider videosProvider;

        public Video Videos { get; set; }
        
        // Marked as BindProperty for use link bidirectional and support of get/post 
        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }

        public VideosModel(IVideosProvider videosProvider)
        {
            this.videosProvider = videosProvider;
        }

        public async Task<IActionResult> OnGet()
        {
            // Getting all Videos on the list
            var results = await videosProvider.GetAllAsync(Search);
            if (results != null)
            {
                Videos = results;
            }
            

            return Page();
        }
    }
}