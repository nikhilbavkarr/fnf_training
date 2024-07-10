

Day 1 : Basics, Enum , Class And Object , Array





using System;
using System.Collections.Generic;
using System.Linq;

public class BookSorter
{
    public static List<string> SortTitles(List<string> books)
    {
        // Parse the book titles and authors
        var bookEntries = new List<BookEntry>();
        
        foreach (var book in books)
        {
            // Extract book title and author(s) from the string
            var parts = book.Split(" by ");
            if (parts.Length < 2) continue; // Skip malformed entries
            
            var title = parts[0].Trim(' ', '"');
            var authors = parts[1];
            var firstAuthor = authors.Split(" and ")[0].Trim();
            
            bookEntries.Add(new BookEntry(title, firstAuthor));
        }
        
        // Sort the entries based on the first author's name and then book title
        var sortedEntries = bookEntries
            .OrderBy(e => e.Author)
            .ThenBy(e => e.Title)
            .ToList();
        
        // Extract the sorted titles
        var sortedTitles = sortedEntries.Select(e => e.Title).ToList();
        
        return sortedTitles;
    }

    // Helper class to store book title and the first author's name
    private class BookEntry
    {
        public string Title { get; }
        public string Author { get; }

        public BookEntry(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    public static void Main()
    {
        // Sample test
        var books = new List<string>
        {
            "\"The Canterbury Tales\" by Chaucer",
            "\"Algorithms\" by Sedgewick",
            "\"The C Programming Language\" by Kernighan and Ritchie"
        };
        
        var sortedTitles = SortTitles(books);
        foreach (var title in sortedTitles)
        {
            Console.WriteLine(title);
        }
    }
}
