using System;
using System.Collections.Generic;

namespace CodeFirstMigration.Entities
{
    public partial class CategoryBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CategoryId { get; set; }
    }
}
