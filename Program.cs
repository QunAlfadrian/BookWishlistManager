using System;
using System.IO;

namespace BookWishlistManager {
    internal class Program {
        // path variable
        public static string filePath = @"C:\Users\PAVILION GAMING\Documents\Book Saves\books.csv";

        static void Main(string[] args) {
            if (!File.Exists(filePath)) {
                using (StreamWriter sw = File.CreateText(filePath)) { }
            }

            var addLines = new List<string>();
            addLines.Add("Silence,Akiyoshi Rikako,J-Lit");

            File.AppendAllLines(filePath, addLines);
            var lines = File.ReadAllLines(filePath);
            
            foreach (var line in lines) {
                Console.WriteLine(line);
            }
        }
    }
}