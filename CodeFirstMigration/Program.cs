using CodeFirstMigration.Entities;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        using(var dbContext = new AuthorsContext())
        {
            var authors = dbContext.AllAuthors.ToList();
            foreach(var item in authors)
            {
                Console.WriteLine(item.Firstname);
            }
        }
    }
}