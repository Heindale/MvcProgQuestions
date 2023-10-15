using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcProgQuestions.Data;
using MvcProgQuestions.Models;

namespace MvcProgQuestions.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly MvcProgQuestionsContext _context;

        public QuestionsController(MvcProgQuestionsContext context)
        {
            _context = context;
        }

		// GET: Questions
		public async Task<IActionResult> Index()
        {
              return _context.Question != null ? 
                          View(await _context.Question.ToListAsync()) :
                          Problem("Entity set 'MvcProgQuestionsContext.Question'  is null.");
        }

        // GET: Questions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Question == null)
            {
                return NotFound();
            }

            var question = await _context.Question
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }
    }
}
