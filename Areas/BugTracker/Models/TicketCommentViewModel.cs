using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASGay_Portfolio.Areas.BugTracker.Models;

namespace ASGay_Portfolio.Areas.BugTracker.Models
{
        public class TicketCommentViewModel
        {
            public Ticket ticket { get; set; }
            public TicketComment ticketComment { get; set; }
        }
    }
