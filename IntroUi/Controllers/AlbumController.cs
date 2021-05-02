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
    public class AlbumController : Controller
    {
        ChinookContext _context;

        public AlbumController(ChinookContext context)
        {
            _context = context;
        }

        public IActionResult Index(string codigo, string album, string artista, int page = 1)
        {
            int pageSkip = 25 * (page - 1);

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

            ViewBag.Pages = (albums.Count / 25) + 1;
            ViewBag.ActualPage = page;
            
            albums = albums.Skip(pageSkip).Take(25).ToList();

            return View(albums);
        }

        [HttpGet]
        [Route("Album/Details/{albumId?}")]
        public IActionResult Details(int? albumId)
        {
            long id = Convert.ToInt32(albumId);
            var album = _context.Albums.Find(id);
            if(album == null)
            {
                return NotFound();
            }

            var albumDetails = _context.Albums
                .Include(a => a.Artist)
                .Include(a => a.Tracks)
                .Where(a => a.AlbumId == albumId)
                .Select(d => new AlbumDetailViewModel
                {
                    AlbumId = d.AlbumId,
                    Title = d.Title,
                    Artist = d.Artist.Name,
                    Tracks = d.Tracks
                        .ToList()
                        .Select(t => 
                            new TrackViewModel
                            {
                                TrackId = (int) t.TrackId,
                                Name = t.Name,
                                Duration = (int) t.Milliseconds / 1000,
                                Genre = t.Genre.Name,
                                Price = t.UnitPrice
                            }
                        ).ToList()
                }).First();

            return View(albumDetails);
        }
    }
}