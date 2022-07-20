using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using PagedList.Core.Mvc;
using ResearchProject.Models;

namespace ResearchProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCustomersController : Controller
    {
        private readonly CoffeeShopProjectContext _context;

        public AdminCustomersController(CoffeeShopProjectContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminCustomers
        public IActionResult Index(int? page)
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "Description");

            List<SelectListItem> IsStatus = new List<SelectListItem>();
            IsStatus.Add(new SelectListItem() { Text = "Active", Value = "0" });
            IsStatus.Add(new SelectListItem() { Text = "Block", Value = "1" });
            ViewData["IsStatus"] = IsStatus;

            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 5;
            var IsCustomers = _context.Customers
                .AsNoTracking()
                .Include(x => x.Location)
                .OrderBy(x => x.CustomerId);
            PagedList<Customer> models = new PagedList<Customer>(IsCustomers, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);

        }
        [HttpPost]
        public IActionResult ExportToExcel()
        {
            var lscus = _context.Customers
                   .Include(x => x.Location)
                   .AsNoTracking()
                   .OrderBy(x => x.CustomerId)
                   .ToList();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Customers");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ID";
                worksheet.Cell(currentRow, 2).Value = "FullName";
                worksheet.Cell(currentRow, 3).Value = "BirthDay";
                worksheet.Cell(currentRow, 4).Value = "Address";
                worksheet.Cell(currentRow, 5).Value = "Email";
                worksheet.Cell(currentRow, 6).Value = "Phone";
                foreach (var item in lscus)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.CustomerId;
                    worksheet.Cell(currentRow, 2).Value = item.FullName;
                    worksheet.Cell(currentRow, 3).Value = item.Birthday;
                    worksheet.Cell(currentRow, 4).Value = item.Address;
                    worksheet.Cell(currentRow, 5).Value = item.Email;
                    worksheet.Cell(currentRow, 6).Value = item.Phone;
                    worksheet.Cell(currentRow, 3).Style.DateFormat.Format = "yyyy/mm/dd";
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "customers.xlsx");
                }
            }
        }

        // GET: Admin/AdminCustomers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.Location)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Admin/AdminCustomers/Create
        public IActionResult Create()
        {
            ViewData["LocationId"] = new SelectList(_context.Locations, "LocationId", "LocationId");
            return View();
        }

        // POST: Admin/AdminCustomers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FullName,Birthday,Avatar,Address,Email,Phone,LocationId,District,Ward,CreateDate,Password,Salt,LastLogin,Active")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "LocationId", "LocationId", customer.LocationId);
            return View(customer);
        }

        // GET: Admin/AdminCustomers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "LocationId", "LocationId", customer.LocationId);
            return View(customer);
        }

        // POST: Admin/AdminCustomers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,FullName,Birthday,Avatar,Address,Email,Phone,LocationId,District,Ward,CreateDate,Password,Salt,LastLogin,Active")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationId"] = new SelectList(_context.Locations, "LocationId", "LocationId", customer.LocationId);
            return View(customer);
        }

        // GET: Admin/AdminCustomers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.Location)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Admin/AdminCustomers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }
    }
}
