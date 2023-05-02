using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookWishlistManager {
    public class FileWriter {
        public void NewLine(string filePath) {
            var addLines = new List<string>();
            string userInput;

            userInput = Convert.ToString(Console.ReadLine());
            addLines.Add(userInput);

            Console.WriteLine(addLines[0]);
        }
    }
}
