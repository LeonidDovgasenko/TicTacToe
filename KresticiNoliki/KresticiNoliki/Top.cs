using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KresticiNoliki
{
    public partial class Top : Form
    {
        public Top()
        {
            InitializeComponent();
            topic();
        }
        public void topic()
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
            string namemax = "0";
            for (int j = 0; j < 10; j++)
            {
                if (toplist == null)
                    break;
                string name = "";
                string score = "";
                int kolpro = 0;
                int namepos = 0;
                int maxim = -1;
                for (int i = 0; i < toplist.Length; i++)
                {
                    if (toplist[i] == ' ')
                        kolpro++;
                    else if (i == toplist.Length - 2)
                    {
                        score += toplist[i];
                        int schet = Int32.Parse(score);
                        if (schet > maxim)
                        {
                            namemax = name;
                            maxim = schet;
                            namepos = i - score.Length - name.Length;
                        }
                        break;
                    }
                    else if (kolpro == 0)
                        name += toplist[i];
                    else if (kolpro == 1)
                    {
                        score += toplist[i];
                    }
                    else if (kolpro == 2)
                    {
                        int schet = Int32.Parse(score);
                        if (schet > maxim)
                        {
                            namemax = name;
                            maxim = schet;
                            namepos = i - score.Length - name.Length - 2;

                        }
                        kolpro = 0;
                        score = "";
                        name = "";
                        i--;
                    }
                }
                try
                { 
                toplist = toplist.Remove(namepos, namemax.Length + maxim.ToString().Length + 3);
                textBox1.Text += namemax + " " + maxim + Environment.NewLine;
                }
                catch
                {
                    textBox1.Text += toplist + Environment.NewLine;
                    toplist = null;
                }
               
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void Down_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point lastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MenuForm1 window = new MenuForm1();
            window.StartPosition = FormStartPosition.Manual;
            window.Location = Location;
            window.Show();
            this.Hide();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Down_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Down_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
