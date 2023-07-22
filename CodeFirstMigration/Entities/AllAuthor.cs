using System;
using System.Collections.Generic;

namespace CodeFirstMigration.Entities
{
    public partial class AllAuthor
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
