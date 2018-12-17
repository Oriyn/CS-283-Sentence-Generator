using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_generation
{
    public partial class Form1 : Form
    {
       private Dictionary<string, List<string>> dictText = new Dictionary<string, List<string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string inputPhrase = inputText.Text.Replace(",","").Replace(";","");
            string [] inputSentence = inputPhrase.Split('.', '!','?');
            foreach(var sentence in inputSentence)
            {
                string[] words = sentence.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (!dictText.ContainsKey(words[i]))
                    {
                        dictText[words[i]] = new List<string>();
                    }
                    if (i + 1 < words.Length)
                    {
                        dictText[words[i]].Add(words[i + 1]);
                    }
                }
            }
           
            string outputSentence = "";

            var keys = dictText.Keys.ToArray();
            Random rnr = new Random();
            int rng = rnr.Next(0, keys.Length - 1 );

            var currentKey = keys[rng];
            outputSentence += currentKey;
            outputSentence += " ";
            while (dictText[currentKey].Count != 0)
            {
                var listRng = rnr.Next(0, dictText[currentKey].Count - 1);
                currentKey = dictText[currentKey][listRng];
                outputSentence += currentKey;
                outputSentence += " ";                
            }
            outputSentence = outputSentence.Substring(0, outputSentence.Length - 1);
            outputSentence += ".";
            outputText.Text = outputSentence;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }       
    }
}
