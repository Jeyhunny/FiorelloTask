using EntityFramework_Slider.Data;
using EntityFramework_Slider.Models;
using EntityFramework_Slider.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice.Models;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace EntityFramework_Slider.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();

            SliderInfo sliderInfo = await _context.SliderInfos.FirstOrDefaultAsync();

            IEnumerable<Blog> blogs = await _context.Blogs.Where(m=>!m.SoftDelete).ToListAsync();

            IEnumerable<Category> categories = await _context.Categories.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<Product> products = await _context.Products.Include(m=>m.Images).Where(m => !m.SoftDelete).ToListAsync();

            About about = await _context.Abouts.FirstOrDefaultAsync();
            ExpertHeader expertHeader = await _context.ExpertHeaders.FirstOrDefaultAsync();

            IEnumerable<Instagram> instagrams = await _context.Instagrams.ToListAsync();

            IEnumerable<Author> authors = await _context.Authors.Include(a => a.Says).ToListAsync();
            

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo,
                Blogs = blogs,
                Categories = categories,
                Products = products,
                About = about,
                ExpertHeader = expertHeader,
                Instagrams = instagrams

            };

            return View(model);
        }
    }
}