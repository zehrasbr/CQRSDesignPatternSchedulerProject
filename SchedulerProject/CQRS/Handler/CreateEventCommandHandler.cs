using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedulerProject.CQRS.Handler
{
    public class CreateEventCommandHandler
    {
        private readonly DbContext _context;

        public CreateCalenderEventCommandHandler(DbContext context)
        {
            _context = context;
        }
        public void Handle(CalendarEvent calendarEvent)
        {
            _context.Events.Add(new CalendarEvent
            {
                Color = calendarEvent.Color,
                End = calendarEvent.End,
                Start = calendarEvent.Start,
                Text = calendarEvent.Text
            });
            _context.SaveChanges();
        }
    }
}