using System;
using System.Collections.Generic;

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
        bookEntries.Sort((e1, e2) =>
        {
            int authorComparison = string.Compare(e1.Author, e2.Author, StringComparison.Ordinal);
            if (authorComparison != 0)
            {
                return authorComparison;
            }
            return string.Compare(e1.Title, e2.Title, StringComparison.Ordinal);
        });
        
        // Extract the sorted titles
        var sortedTitles = new List<string>();
        foreach (var entry in bookEntries)
        {
            sortedTitles.Add(entry.Title);
        }
        
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
