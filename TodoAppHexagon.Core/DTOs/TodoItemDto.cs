﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppHexagon.Core.DTOs
{
    public class TodoItemDto
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string IsCompleted { get; set; }
    }
}
