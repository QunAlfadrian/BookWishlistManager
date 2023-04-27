using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWishlistManager {
    public class Book {
        public string title { get; set; }
        public int price { get; set; }
        public bool owned { get; set; }

        public void PrintComponents() {
            if (title.Length <= 7) {
                Console.WriteLine("{0}\t\t\t\t{1}\t\t{2}", title, price, owned);
            } else if (title.Length > 7 && title.Length <= 14) {
                Console.WriteLine("{0}\t\t\t{1}\t\t{2}", title, price, owned);
            } else {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", title, price, owned);
            }
        }
    }

}
