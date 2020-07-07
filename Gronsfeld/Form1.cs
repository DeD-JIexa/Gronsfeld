using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gronsfeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ";

        private void Coder_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartCoder_Click(object sender, EventArgs e)
        {
            int[] keys = "2143658790".Select(ch => (int)Char.GetNumericValue(ch)).ToArray();
            string s = Convert.ToString(Coder.Text);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(alphabet[(alphabet.IndexOf(s[i]) + keys[i % keys.Length]) % alphabet.Length]);
                Encoder.Text = Convert.ToString(sb);
            }
        }
        #region Text
        private void Encoder_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
