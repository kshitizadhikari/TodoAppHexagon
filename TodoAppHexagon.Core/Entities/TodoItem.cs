﻿]using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppHexagon.Core.Entities
{
    public sealed class TodoItem
    {
        Guid Id { get; set; }
        public required string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
