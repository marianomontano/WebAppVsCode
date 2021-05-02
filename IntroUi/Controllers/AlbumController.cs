using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using IntroUi.Models;

namespace IntroUi.Controllers
{
    public class AlbumController : Controller
    {
        ChinookContext _context;

        public AlbumController(ChinookContext context)
        {
            _context = context;
        }

        public IActionResult Index(string codigo, string album, string artista, int page = 1)
        {
            int pageSkip = 10 * (page - 1);

            var albums = _context.Albums
                .Include(a => a.Artist)
                .ToList();

            if(!string.IsNullOrEmpty(codigo))
            {
                int cod = Convert.ToInt32(codigo);
                albums = albums.Where(a => a.AlbumId == cod).ToList();
            }

            if(!string.IsNullOrEmpty(album))
            {
                albums = albums.Where(a => a.Title.Contains(album)).ToList();
            }

            if(!string.IsNullOrEmpty(artista))
            {
                albums = albums.Where(a => a.Artist.Name.Contains(artista)).ToList();
            }

            ViewBag.Pages = (albums.Count / 10) + 1;
            ViewBag.ActualPage = page;
            
            albums = albums.Skip(pageSkip).Take(10).ToList();

            return View(albums);
        }
    }
}