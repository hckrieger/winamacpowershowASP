using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Winamacpowershow.Models;
using Winamacpowershow.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Winamacpowershow.Pages.Notifications
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Notification> Notification { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Notifications != null)
            {
                Notification = await _context.Notifications.ToListAsync();
            }
        }
    }
}
