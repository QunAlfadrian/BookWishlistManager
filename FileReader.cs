using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookWishlistManager {

    internal class FileReader {
        string FilePath = @"C:\Users\PAVILION GAMING\Documents\Book Saves\books.csv";
        public string[] ReadToArray(string filePath) {
            string[] lines;

            lines = File.ReadAllLines(filePath);
            return lines;
        }

        public List<Book> CreateBookList(string filePath, string[] lineArray) {
            var books = new List<Book>();
            string[] lineWords;

            foreach (string line in lineArray) {
                Book book = new Book();
                lineWords = line.Split(',');
                book.Title = lineWords[0];
                book.Price = Convert.ToInt32(lineWords[1]);
                book.Status = Convert.ToBoolean(lineWords[2]);
                books.Add(book);
            }

            return books;
        }
    }
}
