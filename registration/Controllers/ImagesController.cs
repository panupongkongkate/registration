using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using registration.Models;

namespace registration.Controllers
{
    public class ImagesController : Controller
    {
        private readonly ImageDbCondext _context;

        public IWebHostEnvironment _HostEnvironment { get; }

        public ImagesController(ImageDbCondext context, IWebHostEnvironment hostEnvironment )
        {
            _context = context;
            _HostEnvironment = hostEnvironment;
        }

        // GET: Images
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegImage.Include(e => e.Gender).Include(e => e.Position).ToListAsync());
        }

        // GET: Images/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var images = await _context.RegImage.Include(e => e.Gender).
                Include(e => e.Position).FirstOrDefaultAsync(m => m.ID == id);

            if (images == null)
            {
                return NotFound();
            }

            return View(images);
        }

        // GET: Images/Create
        public IActionResult Create()
        {
            ViewData["GenderId"] = new SelectList(_context.MasterGender, "GenderId", "GenderName");
            ViewData["PositionId"] = new SelectList(_context.MasterPosition, "PositionId", "PositionName");
            return View();
        }

        // POST: Images/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Email,Password,ConfirmPassword,Dateofbirth,Phonenumber,Height,Weight,GenderId,PositionId,ImageFile")] Images images)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //save image to wwwroot folder
                    string wwwRootPath = _HostEnvironment.WebRootPath;

                    string Filename = Path.GetFileNameWithoutExtension(images.ImageFile.FileName);

                    string extension = Path.GetExtension(images.ImageFile.FileName);

                    //DateTime.Now ใช้เพราะ จะได้ไม่ซ้ำ
                    Filename = Filename + DateTime.Now.ToString("yymmssfff") + extension;

                    images.ImageName = Filename;

                    string path = Path.Combine(wwwRootPath + "/Images/" + Filename);

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await images.ImageFile.CopyToAsync(fileStream);
                    }

                    _context.Add(images);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return View(images);
        }

        // GET: Images/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var images = await _context.RegImage.FindAsync(id);


            if (images == null)
            {
                return NotFound();
            }

            ViewData["GenderId"] = new SelectList(_context.MasterGender, "GenderId", "GenderName", images.GenderId);
            ViewData["PositionId"] = new SelectList(_context.MasterPosition, "PositionId", "PositionName", images.PositionId);

            return View(images);
        }

        // POST: Images/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("ID,FirstName,LastName,Email,Password,ConfirmPassword,Dateofbirth,Phonenumber,Height,Weight,GenderId,PositionId,ImageFile,ImageName")] Images images)
        {
            if (id != images.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(images.ImageFile != null)
                    {
                        //delete image form wwwroot/image
                        var ImagePath = Path.Combine(_HostEnvironment.WebRootPath, "Images", images.ImageName);

                        if (System.IO.File.Exists(ImagePath))
                        {
                            System.IO.File.Delete(ImagePath);

                            //save image to wwwroot folder
                            string wwwRootPath = _HostEnvironment.WebRootPath;

                            string Filename = Path.GetFileNameWithoutExtension(images.ImageFile.FileName);

                            string extension = Path.GetExtension(images.ImageFile.FileName);

                            Filename = Filename + DateTime.Now.ToString("yymmssfff") + extension;

                            images.ImageName = Filename;

                            string path = Path.Combine(wwwRootPath + "/Images/" + Filename);

                            using (var fileStream = new FileStream(path, FileMode.Create))
                            {
                                await images.ImageFile.CopyToAsync(fileStream);
                            }
                        }
                    }    

                    _context.Update(images);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagesExists(images.ID))
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
            return View(images);
        }

        // GET: Images/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var images = await _context.RegImage.Include(e => e.Gender).
       Include(e => e.Position).FirstOrDefaultAsync(m => m.ID == id);

            if (images == null)
            {
                return NotFound();
            }

            return View(images);
        }

        // POST: Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            try
            {
                var imageModel = await _context.RegImage.FindAsync(id);

                //delete image form wwwroot/image
                var ImagePath = Path.Combine(_HostEnvironment.WebRootPath, "Images", imageModel.ImageName);

                if (System.IO.File.Exists(ImagePath))
                {
                    System.IO.File.Delete(ImagePath);
                }

                _context.RegImage.Remove(imageModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }

        }

        private bool ImagesExists(int? id)
        {
            return _context.RegImage.Any(e => e.ID == id);
        }
    }
}
