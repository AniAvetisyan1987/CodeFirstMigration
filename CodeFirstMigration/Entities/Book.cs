using System;
using System.Collections.Generic;

namespace CodeFirstMigration.Entities
{
    public partial class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string BookName { get; set; } = null!;
    }
}
