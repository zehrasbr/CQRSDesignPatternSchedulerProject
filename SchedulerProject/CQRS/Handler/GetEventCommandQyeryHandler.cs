using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedulerProject.CQRS.Handler
{
    public class GetEventCommandQyeryHandler
    {
        private readonly DbContext _context;

        public GetCalenderEventQueryHandler(DbContext context)
        {
            _context = context;
        }
        public List<CalendarEvent> Handle(DateTime start, DateTime end)
        {
            var values = _context.Events
                   .Where(e => !((e.End <= start) || (e.Start >= end)))
                   .ToList();
            return values;
        }
    }
}
}