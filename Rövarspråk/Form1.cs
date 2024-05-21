using System.Text.RegularExpressions;

namespace Rövarspråk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            private void textBox1_TextChanged(object sender, EventArgs e)
            {
           
                string inputText = textBox1.Text.ToLower(); // Konvertera till gemener för enklare hantering
                string translatedText = TranslateToRovarsprak(inputText);
                textBox2.Text = translatedText;
            
            }

            private string TranslateToRovarsprak(string input)
            {
            // Ändrar så att x behandlas som ks
            input = input.Replace("x", "ks").Replace("X", "KS");
            // Regex för att hitta konsonanter (ej mellanslag, siffror eller specialtecken)
            string consonantsPattern = @"[^aeiouyåäö\s\d\W]";
                // Regex.Replace ersätter varje matchning med matchningen + 'o' + matchningen

                string translatedText = Regex.Replace(input, consonantsPattern, m => m.Value + "o" + m.Value);
                return translatedText;
            }
        
    }
}
