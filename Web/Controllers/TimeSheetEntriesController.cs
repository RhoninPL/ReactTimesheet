using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class TimeSheetEntriesController : Controller
    {
        private readonly TimeSheetContext _context;

        public TimeSheetEntriesController(TimeSheetContext context)
        {
            _context = context;    
        }
        
        [Route("GetTimeSheetEntries")]
        public IActionResult GetTimeSheetEntries()
        {
            var json = _context.Entries.ToList();
            return new ObjectResult(json);
        }
    }
}
