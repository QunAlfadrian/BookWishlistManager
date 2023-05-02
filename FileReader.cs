using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookWishlistManager {
    internal class FileReader {
        public string[] ReadToArray(string filePath) {
            string[] lines;

            lines = File.ReadAllLines(filePath);
            return lines;
        }
    }
}
