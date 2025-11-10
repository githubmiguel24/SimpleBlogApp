using Microsoft.AspNetCore.Mvc;
using SimpleBlogApp.Models; // <-- Change to your project's namespace
using System.Collections.Generic;
using System.Linq;

namespace SimpleBlogApp.Controllers // <-- Change to your project's namespace
{
    public class BlogController : Controller
    {
        //Mock Posts
        private static List<Post> _posts = new List<Post>
        {
            new Post { Id = 1, Title = "Boom TARAT TARAT - The Curious Case of Willy Revillame", Author = "Charles Miguel Trinidad", Content = "Ikaw na nga, ang hinahanap ng puso..." },
            new Post { Id = 2, Title = "DUMILIG ANG PALIGID - SPOLARIUM ANALYSIS", Author = "Kurt Michael Daanay", Content = "Ely Buendia vs Vic Sotto" },
            new Post { Id = 3, Title = "WHY DID THE LION CROSS THE RIVER?", Author = "MARAÑO, Alexander", Content = "ROAR" }
        };

        //Index
        public IActionResult Index()
        {
            return View(_posts);
        }

        //Details
        public IActionResult Details(int id) {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }
    }
}