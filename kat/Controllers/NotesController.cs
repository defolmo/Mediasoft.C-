using Microsoft.AspNetCore.Mvc;
using NoteApp.Data;
using NoteApp.Models;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace NoteApp.Controllers
{
    public class NotesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<NotesController> _logger;

        public NotesController(AppDbContext context, ILogger<NotesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index(Guid categoryId)
        {
            var notes = _context.Notes
                .Where(n => n.CategoryId == categoryId)
                .ToList();
            ViewBag.CategoryId = categoryId;
            return View(notes);
        }

        public IActionResult Create(Guid categoryId)
        {
            ViewBag.CategoryId = categoryId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Note note)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation("Creating a new note with CategoryId: {CategoryId}", note.CategoryId);
                _context.Notes.Add(note);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index), new { categoryId = note.CategoryId });
            }
            ViewBag.CategoryId = note.CategoryId; // Ensure CategoryId is passed back to the view
            return View(note);
        }

        public IActionResult Delete(Guid id)
        {
            var note = _context.Notes.Find(id);
            if (note == null)
            {
                return NotFound();
            }
            var categoryId = note.CategoryId;
            _context.Notes.Remove(note);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index), new { categoryId });
        }
    }
}
