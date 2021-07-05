


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cet322FinalProject.Models;
using Cet322FinalProject.Data;
using Cet322FinalProject.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cet322FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomePageViewModel();

            var applicationDbContext = _context.Posts.Include(p => p.Category).Include(p => p.PostImages);
            model.Posts = await applicationDbContext.ToListAsync();

            var applicationDbContextGallery = _context.Galleries.Include(g => g.GalleryImages);
            model.Gallery = await applicationDbContextGallery.ToListAsync();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Search()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Search(SearchViewModel searchModel)
        {

            IQueryable<Post> posts = _context.Posts.AsQueryable().Include(b => b.PostImages);

            if (!String.IsNullOrWhiteSpace(searchModel.SearchText))
            {
                if (searchModel.SearchInDescription)
                {
                    posts = posts.Where(b => b.Title.Contains(searchModel.SearchText) || b.Description.Contains(searchModel.SearchText));
                }
                else
                {
                    posts = posts.Where(b => b.Title.Contains(searchModel.SearchText));
                }
            }

            if (searchModel.CategoryId.HasValue)
            {
                posts = posts.Where(b => b.CategoryId == searchModel.CategoryId.Value);
            }


            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", searchModel.CategoryId);
            searchModel.Results = await posts.ToListAsync();
            return View(searchModel);
        }


    }
}