

Day 1 : Basics, Enum , Class And Object , Array





import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

public class BookSorter {

    public static List<String> SortTitles(List<String> books) {
        List<BookEntry> entries = new ArrayList<>();
        
        for (String book : books) {
            // Extract book title and author from the string
            String[] parts = book.split(" by ");
            if (parts.length < 2) continue; // Skip malformed entries
            
            String title = parts[0].replace("\"", "").trim();
            String authors = parts[1];
            String[] authorsArray = authors.split(" and ");
            String firstAuthor = authorsArray[0].trim();
            
            entries.add(new BookEntry(title, firstAuthor));
        }
        
        // Sort the entries based on the first author's name and then book title
        Collections.sort(entries, new Comparator<BookEntry>() {
            @Override
            public int compare(BookEntry e1, BookEntry e2) {
                int authorComparison = e1.author.compareTo(e2.author);
                if (authorComparison != 0) {
                    return authorComparison;
                } else {
                    return e1.title.compareTo(e2.title);
                }
            }
        });
        
        // Extract the sorted titles
        List<String> sortedTitles = new ArrayList<>();
        for (BookEntry entry : entries) {
            sortedTitles.add(entry.title);
        }
        
        return sortedTitles;
    }
    
    // Helper class to store book title and the first author's name
    private static class BookEntry {
        String title;
        String author;

        BookEntry(String title, String author) {
            this.title = title;
            this.author = author;
        }
    }

    public static void main(String[] args) {
        // Sample test
        List<String> books = List.of(
            "\"The Canterbury Tales\" by Chaucer",
            "\"Algorithms\" by Sedgewick",
            "\"The C Programming Language\" by Kernighan and Ritchie"
        );
        List<String> sortedTitles = SortTitles(books);
        System.out.println(sortedTitles);
    }
}
