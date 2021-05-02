using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using IntroUi.Models;
using IntroUi.ViewModels;

namespace IntroUi.Controllers
{
    public class ArtistController : Controller
    {
        ChinookContext _context;

        public ArtistController(ChinookContext context)
        {
            _context = context;
        }

        public IActionResult Index(string name, int page = 1)
        {
            int pageSkip = 25 * (page - 1);

            var artists = _context.Artists.ToList();

            if(!string.IsNullOrEmpty(name))
            {
                artists = artists.Where(a => a.Name.Contains(name)).ToList();
            }

            ViewBag.Pages = (artists.Count / 25) +1;
            ViewBag.ActualPage = page;
            artists = artists.Skip(pageSkip).Take(25).ToList();

            return View(artists);
        }
    }
}