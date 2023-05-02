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
            //writer.AppendLines(FilePath, lineList);

            string[] lines;
            lines = reader.ReadToArray(FilePath);
            
            foreach (var line in lines) {
                Console.WriteLine(line);
            }

            Console.WriteLine("\n"+lines);
        }

        static void CreateFile(string filePath) {
            if (!File.Exists(filePath)) {
                using (StreamWriter create = File.CreateText(filePath)) { }
            }
        }
    }
}