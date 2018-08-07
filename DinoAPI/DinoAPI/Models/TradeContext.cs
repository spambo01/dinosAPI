﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DinoAPI.Models
{
    public class TradeContext:DbContext
    {
        public TradeContext(DbContextOptions<TradeContext> options)
            : base(options)
        {
        }

        public DbSet<Trade> TodoItems { get; set; }
    }
}
