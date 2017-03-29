using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class TimeSheetEntry
    {
        public int TimeSheetEntryId { get; set; }

        public string Company { get; set; }

        public string User { get; set; }

        public float WorkTime { get; set; }
    }
}
