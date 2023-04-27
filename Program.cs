using System;
using System.IO;

namespace BookWishlistManager {
    internal class Program {
        // path variable
        public static string filePath = "bookList.csv";
        public static List<Book> books = ConvertToArr(filePath);

        static void Main(string[] args) {
            // loop variable
            bool pilihLagi = true;

            // input variable
            int menuInput;

            Console.WriteLine("Selamat Datang");
            ReadFile(ConvertToArr(filePath));

            while (pilihLagi) {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Pilih Menu: ");
                Console.WriteLine(" <1> Read");
                Console.WriteLine(" <2> Update");
                Console.WriteLine(" <3> Write");
                Console.WriteLine(" <4> Keluar");

                menuInput = Convert.ToInt32(Console.ReadLine());

                switch (menuInput) {
                    case 1:
                        ReadFile(books);
                        break;
                    case 2:
                        Console.WriteLine(GetLineIndex());
                        Console.WriteLine(SelectAttribute());
                        break;
                    case 3:
                        AddEntry();
                        break;
                    case 4:
                        pilihLagi = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid");
                        break;
                }
            }

        }

        // read methods
        static List<Book> ConvertToArr(string path) {
            var lines = File.ReadAllLines(path);
            var localBooks = new List<Book>();

            foreach (var line in lines) {
                var components = line.Split(',');
                var book = new Book() {
                    title = components[0],
                    price = Convert.ToInt32(components[1]),
                    owned = Convert.ToBoolean(components[2]),
                };
                localBooks.Add(book);
            }
            return localBooks;
        }

        static void ReadFile(List<Book> books) {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Judul\t\t\t\tHarga\t\tSudah Beli?\n");
            foreach (var book in books) {
                book.PrintComponents();
            }
            Console.WriteLine();
        }

        // update methods
        static int GetLineIndex() {
            int lineIndex;

            Console.WriteLine("Masukkan nomor baris:");
            lineIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            return lineIndex;
        }

        static int SelectAttribute() {
            int menuInput;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pilih atribut yang diedit:");
            Console.WriteLine(" <1> Judul");
            Console.WriteLine(" <2> Harga");
            Console.WriteLine(" <3> Status Kepemilikan");
            Console.WriteLine(" <4> Batal");

            menuInput = Convert.ToInt32((Console.ReadLine()));

            return menuInput;
        }

        // write methods
        static Book CreateBook() {
            char isOwned;
            Book book = new Book();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Masukkan judul Buku");
            book.title = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nMasukkan harga Buku");
            book.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nApakah sudah punya? [y|n]");
            isOwned = Convert.ToChar(Console.ReadLine());

            if (isOwned == 'y') {
                book.owned = true;
            } else {
                book.owned = false;
            }

            return book;
        }

        static void WriteFile(Book book, string path) {
            string bookTitle = book.title;
            string bookPrice = Convert.ToString(book.price);
            string bookOwned = Convert.ToString(book.owned);

            try {
                using (StreamWriter file = new StreamWriter(@path, true)) {
                    file.WriteLine(bookTitle + "," + bookPrice + "," + bookOwned);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        static void AddEntry() {
            Book book = CreateBook();

            WriteFile(book, filePath);
        }
    }
}