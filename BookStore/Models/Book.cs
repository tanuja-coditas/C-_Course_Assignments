using System;
using System.Collections.Generic;

namespace BookStore.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? BookName { get; set; }

    public string? AuthorName { get; set; }

    public decimal? Cost { get; set; }
}
