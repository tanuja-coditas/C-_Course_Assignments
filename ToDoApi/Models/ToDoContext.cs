﻿using Microsoft.EntityFrameworkCore;
using ToDoApi.Models;
namespace ToDoApi.Models
{
    public class ToDoContext:DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
        : base(options)
        {
        }

        public DbSet<ToDoItem> TodoItems { get; set; } = null!;
    }
}
