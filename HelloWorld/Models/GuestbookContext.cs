﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HelloWorld.Models
{
    public class GuestbookContext : DbContext
    {
        public GuestbookContext()
            : base("Guestbook")
        {
        }

        public DbSet<GuestbookEntry> Entries { get; set; }
    }
}