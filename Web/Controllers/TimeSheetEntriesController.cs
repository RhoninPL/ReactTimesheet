using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Web.Models;

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

        [HttpPost]
        [Route("AddEntry")]
        public IActionResult AddEntry([FromBody]NewEntry newEntry)
        {
            if (newEntry == null)
                return new BadRequestResult();

            _context.Entries.Add(new TimeSheetEntry()
            {
                Company = newEntry.Company,
                User = newEntry.User,
                WorkTime = newEntry.Time
            });

            _context.SaveChanges();

            return new OkResult();
        }

        [HttpPost]
        [Route("EditEntry")]
        public IActionResult EditEntry([FromBody] EditEntry editEntry)
        {
            if (editEntry == null)
                return new BadRequestResult();

            var entry = _context.Entries.FirstOrDefault(item => item.TimeSheetEntryId == editEntry.Id);
            if (entry == null)
                return new NotFoundResult();

            entry.Company = editEntry.Company;
            entry.WorkTime = editEntry.Time;
            entry.User = editEntry.User;

            _context.SaveChanges();

            return new OkResult();
        }
    }
}
