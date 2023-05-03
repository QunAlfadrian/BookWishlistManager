using System;
using System.IO;

namespace BookWishlistManager {
    internal class Program {
        // path variable
        public static string FilePath = @"C:\Users\PAVILION GAMING\Documents\Book Saves\books.csv";
        public static FileWriter writer = new FileWriter();
        public static FileReader reader = new FileReader();
        public static Book book = new Book();

        static void Main(string[] args) {
            CreateFile(FilePath);

            //var lineList = writer.LineList(FilePath);
            //writer.WriteLines(FilePath, lineList);

            string[] lines = reader.ReadToArray(FilePath);

            List<Book> books = new List<Book>();
            books = reader.CreateBookList(FilePath, lines);
            
            foreach (var book in books) {
                book.PrintComponents();
            }

            Console.WriteLine("\n"+books);
        }

        static void CreateFile(string filePath) {
            if (!File.Exists(filePath)) {
                using (StreamWriter create = File.CreateText(filePath)) { }
            }
        }
    }
}