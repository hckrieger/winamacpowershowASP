using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Winamacpowershow.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Winamacpowershow.Models;

namespace Winamacpowershow.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            _logger = logger;

            _context = context;
        }

        public IList<Notification> Notifications { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Notifications != null)
            {
                Notifications = await _context.Notifications.ToListAsync();
            }
        }
    }
}