﻿using eTickets.Data.Enum;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)    
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
             return View(await _context.Actors.ToListAsync());
        }
    }
}
