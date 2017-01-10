using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace test
{
    public partial class Wordinator : Form
    {
        private int textlength;
        private char[] primaryText1 = new char[] { };

        private int[] indexArray = new int[] { };
        private int percent = 0;
        private string[] primaryText2 = new string[] { };

        Random rng = new Random();
        private string[] changedText2 = new string[] { };

        public Wordinator()
        {
            InitializeComponent();
        }

        private void letterChangeButton_Click(object sender, EventArgs e)
        {

            GetTextInChars(out textlength, out primaryText1);
            int percent = GetPercentage(textlength);
            indexArray = GetRandomNumbers(percent, textlength, indexArray);
            char[] tempArray = FindElements1();
            Shuffle(indexArray);
            char [] changedText1 = ChangeText1(tempArray);

            //changedTextBox.Text = percent.ToString();
            changedTextBox.Text = /*string.Join(", ", indexArray) + " " + string.Join(", ", tempArray) + " " +
                string.Join(", ", indexArray) + " " +*/
                string.Join("", changedText1); 
   
        }

        private void wordChangeButton_Click(object sender, EventArgs e)
        {
            GetTextInWords(out textlength, out primaryText2);
            int percent = GetPercentage(textlength);
            indexArray = GetRandomNumbers(percent, textlength, indexArray);

            string[] tempArray = FindElements2();
            int k = 0;
            int oldIndexValue = 0;
            if (indexArray.Length == 1)
            {
                k = rng.Next(0, textlength);
                oldIndexValue = indexArray[0]; 
                indexArray[0] = k;
            }
            else
            {
                Shuffle(indexArray);
            }
            List<string> list = new List<string>();
            string[] changedText2;
            if (indexArray.Length!=1)
            {
                changedText2 = ChangeText2(tempArray);
            }
            else
            {
                
                list = primaryText2.OfType<string>().ToList();
                list.RemoveAt(oldIndexValue);
                list.Insert(k, primaryText2[oldIndexValue]);
                changedText2 = list.ToArray();
            }
            

            changedTextBox.Text = /*/*percent.ToString() string.Join(", ", indexArray) + " " + string.Join(", ", tempArray) + " " +
                string.Join(", ", indexArray) + " " +*/
                string.Join(" ", changedText2);
            
        }


        
        private void GetTextInChars(out int textlength, out char[] primaryText1)
        {
            string primaryChars = primaryTextBox.Text;
            primaryText1 = primaryChars.ToCharArray();
            textlength = primaryText1.Length;
        }

        private void GetTextInWords(out int textlength, out string[] primaryText2)
        {
            //char[] e = { ' ', ',', '.', ':', ';', '!', '?', '<', '>', '/', '\\', '\t', '\n', '\'', '\"', '-' };
            primaryText2 = primaryTextBox.Text.Split(' ');
            textlength = primaryText2.Length;
        }

        private int GetPercentage(int textlength)
        {
            int x;
            Int32.TryParse(percentTextBox.Text, out x);
            percent = x * textlength / 100;
            return percent;
        }

        private int[] GetRandomNumbers(int percent, int textlength, int[] indexArray)
        {

            List<int> elements = new List<int>();
            Random nr = new Random();

            for (int i = 0; i < percent;)
            {

                int randomNumber = nr.Next(0, textlength);

                while (!(elements.Contains(randomNumber)))
                {
                    elements.Add(randomNumber);
                    i++;
                }
            }
            indexArray = elements.ToArray();
            return indexArray;
        }

        private char[] FindElements1()
        {
            List<char> tempList1 = new List<char>();

            for (int j = 0; j < indexArray.Length; j++)
            {
                int indexValue = indexArray[j];
                if (indexValue != Array.IndexOf(primaryText1, j))
                {
                    char tempElement = primaryText1[indexValue];
                    tempList1.Add(tempElement);
                }
            }
            char[] tempArray = tempList1.ToArray();
            return tempArray;
        }

        private string[] FindElements2()
        {
            List<string> tempList2 = new List<string>();

            for (int j = 0; j < indexArray.Length; j++)
            {
                int indexValue = indexArray[j];
                if (indexValue != Array.IndexOf(primaryText2, j))
                {
                    string tempElement = primaryText2[indexValue];
                    tempList2.Add(tempElement);
                }
            }
            string[] tempArray = tempList2.ToArray();
            return tempArray;
        }
        private void Shuffle<T>(T[] indexArray)
        {

            int n = indexArray.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = indexArray[n];
                indexArray[n] = indexArray[k];
                indexArray[k] = temp;        
            }
        }

        private char[] ChangeText1(char[] tempArray)
        {
            for (int g = 0; g < indexArray.Length; g++)
            {
                int shuffledIndexValue = indexArray[g];
                char newTextValue = tempArray[g];

                primaryText1[shuffledIndexValue] = newTextValue;

            }
            return primaryText1;
        }

        private string[] ChangeText2(string[] tempArray)
        {
            for (int g = 0; g < indexArray.Length; g++)
            {
                int shuffledIndexValue = indexArray[g];
                string newTextValue = tempArray[g];

                primaryText2[shuffledIndexValue] = newTextValue;

            }
            return primaryText2;
        }

    }

}
