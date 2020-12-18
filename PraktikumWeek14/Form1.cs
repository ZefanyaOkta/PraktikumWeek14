using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek14
{
    public partial class StringForm : Form
    {
        public StringForm()
        {
            InitializeComponent();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu");
            }
            else
            {
                string Text1 = textBoxInput.Text;
                char[] rev = Text1.ToCharArray();
                Array.Reverse(rev);
                string Txt = string.Empty;
                for (int i = 0; i <= rev.Length - 1; i++)
                {
                    Txt = Txt + rev.GetValue(i);
                }
                labelOutput.Text = Txt;
            }
            
            
        }

        private void buttonUrutkan_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu");
            }
            else
            {
                string Text1 = textBoxInput.Text;
                char[] sort = Text1.ToCharArray();
                Array.Sort(sort, StringComparer.Ordinal);

                string srt = string.Empty;
                for (int i = 0; i <= sort.Length - 1; i++)
                {
                    srt = srt + sort.GetValue(i);
                }
                labelOutput.Text = srt;
            }
        }
    }
}
