using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KresticiNoliki
{
    public partial class winpage : Form
    {
        public winpage()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }
        public void score()
        {
            StreamReader sr = new StreamReader(@"..\..\toplist.txt");
            string line = "0";
            string toplist = "";
            line = sr.ReadLine();
            while (line != null)
            {
                toplist += line + " ";
                line = sr.ReadLine();
            }
            sr.Close();
            line = "";
            for (int i=toplist.Length-2; toplist[i]!=' '; i--)
            {
                if (toplist[i]!=' ')
                line = toplist[i] + line;
            }
            int schet = int.Parse(line);
            schet = schet + 1;
            toplist = toplist.Remove(toplist.Length-line.Length, line.Length);
            line=schet.ToString();
            toplist += line;
            File.WriteAllText(@"..\..\toplist.txt", string.Empty);
            StreamWriter sw = new StreamWriter(@"..\..\toplist.txt");
            sw.WriteLine(toplist);
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Вы победили!")
                score();
            Application.Restart();
        }

    }
}
