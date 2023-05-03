using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWishlistManager {
    public class Book {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }

        public void PrintComponents() {
            if (Title.Length <= 7) {
                Console.WriteLine("{0}\t\t\t\t{1}\t\t{2}", Title, Price, Status);
            } else if (Title.Length > 7 && Title.Length <= 15) {
                Console.WriteLine("{0}\t\t\t{1}\t\t{2}", Title, Price, Status);
            } else {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", Title, Price, Status);
            }
        }
    }

}
