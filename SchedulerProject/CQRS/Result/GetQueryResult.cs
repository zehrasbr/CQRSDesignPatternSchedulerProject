using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedulerProject.CQRS.Result
{
    public class GetQueryResult
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Text { get; set; }
        public string Color { get; set; }
    }
}