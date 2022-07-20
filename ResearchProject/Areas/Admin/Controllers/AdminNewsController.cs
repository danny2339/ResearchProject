using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using ResearchProject.Helper;
using ResearchProject.Models;

namespace ResearchProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminNewsController : Controller
    {
        private readonly CoffeeShopProjectContext _context;
        public INotyfService _notyfService { get; }
        public AdminNewsController(CoffeeShopProjectContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminNews
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 5;
            var IsNews = _context.News
                .AsNoTracking()
                .OrderBy(x => x.PostId);
            PagedList<News> models = new PagedList<News>(IsNews, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }
        // GET: Admin/AdminNews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // GET: Admin/AdminNews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminNews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed,MetaKey,MetaDesc,Views")] News news, Microsoft.AspNetCore.Http.IFormFile fthumb)
        {
            if (ModelState.IsValid)
            {
                if (fthumb != null)
                {
                    string extension = Path.GetExtension(fthumb.FileName);
                    string imageName = Utilities.SEOUrl(news.Title) + extension;
                    news.Thumb = await Utilities.UploadFile(fthumb, @"news", imageName.ToLower());
                }
                if (string.IsNullOrEmpty(news.Thumb)) news.Thumb = "default.jpg";
                news.Alias = Utilities.SEOUrl(news.Title);
                news.CreatedDate = DateTime.Now;
                _context.Add(news);
                await _context.SaveChangesAsync();
                _notyfService.Success("Create Successfully");
                return RedirectToAction(nameof(Index));
            }
            return View(news);
        }

        // GET: Admin/AdminNews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }
            return View(news);
        }

        // POST: Admin/AdminNews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed,MetaKey,MetaDesc,Views")] News news, Microsoft.AspNetCore.Http.IFormFile fthumb)
        {
            if (id != news.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (fthumb != null)
                    {
                        string extension = Path.GetExtension(fthumb.FileName);
                        string imageName = Utilities.SEOUrl(news.Title) + extension;
                        news.Thumb = await Utilities.UploadFile(fthumb, @"news", imageName.ToLower());
                    }
                    if (string.IsNullOrEmpty(news.Thumb)) news.Thumb = "default.jpg";
                    news.Alias = Utilities.SEOUrl(news.Title);
                    _context.Update(news);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Update Successfully");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsExists(news.PostId))
                    {
                        _notyfService.Success("Error occurs");
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(news);
        }

        // GET: Admin/AdminNews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: Admin/AdminNews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var news = await _context.News.FindAsync(id);
            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            _notyfService.Success("Delete Successfully");
            return RedirectToAction(nameof(Index));
        }

        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.PostId == id);
        }
    }
}
