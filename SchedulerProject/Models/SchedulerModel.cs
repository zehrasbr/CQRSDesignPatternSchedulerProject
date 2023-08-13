using System;

namespace SchedulerProject.Models
{ 
    public class CalendarDbContext : DbContext
        {
            public DbSet<CalendarEvent> Events { get; set; }
            public CalendarDbContext(DbContextOptions<DbContext> options) : base(options) { }
        }
    public class CalendarEvent
    {
        public int id { get; set; }
        public string text { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public string Color { get; set; }
    }
}