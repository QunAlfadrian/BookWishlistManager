using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookWishlistManager {

    internal class FileReader {
        string FilePath = @"C:\Users\PAVILION GAMING\Documents\Book Saves\books.csv";
        private string[] ReadToArray(string filePath) {
            string[] lines;

            lines = File.ReadAllLines(filePath);
            return lines;
        }

        private Book CreateBook(string line) {
            Book book = new Book();
            string[] lineWords;

            lineWords = line.Split(',');
            book.Title = lineWords[0];
            book.Price = Convert.ToInt32(lineWords[1]);
            book.Status = Convert.ToBoolean(lineWords[2]);
            return book;
        }

        public List<Book> CreateBookList(string filePath) {
            var books = new List<Book>();
            string[] lineArray = ReadToArray(filePath);
            string[] lineWords;

            foreach (string line in lineArray) {
                Book book = CreateBook(line);
                books.Add(book);
            }

            return books;
        }
    }
}
