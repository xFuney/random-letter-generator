using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLetterGen
{
    public partial class Form1 : Form
    {
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public Form1()
        {
            InitializeComponent();
        }

        // Random Number Function
        public int RandomNumber(int min, int max)
        {
            Random random = new Random(); // Generates a variable with datatype Random.
            return random.Next(min, max); // Returns the random number.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // User has pressed button.
            int arrayIndexAvg1 = RandomNumber(0, alphabet.Length - 1);
            int arrayIndexAvg2 = RandomNumber(0, alphabet.Length - 1);
            int arrayIndexAvg3 = RandomNumber(0, alphabet.Length - 1);

            int arrayIndex = (arrayIndexAvg1 + arrayIndexAvg2 + arrayIndexAvg3) / 3;

            RandomVal.Text = Convert.ToString(alphabet[arrayIndex]);
        }
    }
}
