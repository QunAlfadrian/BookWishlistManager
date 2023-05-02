using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookWishlistManager {
    internal class FileWriter {

        private string NewLine() {
            /// <summary>
            /// Method <c>Input</c> takes user input and returns it as string.
            /// </summary>
            string userInput;

            userInput = Console.ReadLine();
            return userInput;
        }

        public void LineList(string filePath) {
            /// <summary>
            /// Method <c>NewLine</c> create a list of <c>Input</c>
            /// </summary>
            var lines = new List<string>();
            bool active = true;
            string text;

            while (active) {
                Console.Write("\n  Masukkan Entry\n\t");
                text = NewLine();
                lines.Add(text);

                if (lines.Count() == 2) { active = false; }
            }

            foreach (string line in lines) {
                Console.WriteLine(line);
            }
        }
    }
}
