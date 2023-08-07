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
    public partial class MenuForm1 : Form
    {
        public MenuForm1()
        {
            InitializeComponent();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Down_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Down_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }



        private void Down_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string line="0";
            string toplist = "";
            if (textBox1.Text != "")
            {
                StreamReader sr = new StreamReader(@"..\..\toplist.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    toplist += line + " ";
                    line = sr.ReadLine();
                }
                sr.Close();
                line = "";
                for (int i = 0; i < toplist.Length; i++)
                {
                    if (toplist[i] == ' ' && line == textBox1.Text)
                    {
                        string score = "";
                        for (int j = i + 1; toplist[j] != ' '; j++)
                        {
                            score += toplist[j];
                        }
                        toplist = toplist.Remove(i - line.Length, line.Length + score.Length + 2);
                        toplist += textBox1.Text + " " + score;
                        break;
                    }
                    else if (i == toplist.Length - 1)
                    {
                        toplist += textBox1.Text + " 0";
                        break;
                    }
                        line += toplist[i];
                     if (toplist[i] == ' ')
                    {
                        line = "";
                    }
                }
                File.WriteAllText(@"..\..\toplist.txt", string.Empty);
                StreamWriter sw = new StreamWriter(@"..\..\toplist.txt");
                sw.WriteLine(toplist);
                sw.Close();
                Game Game = new Game();
                Game.StartPosition = FormStartPosition.Manual;
                Game.Location = Location;
                Game.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введите ваше имя!");
            }
        }

        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Top Top = new Top();
            Top.StartPosition = FormStartPosition.Manual;
            Top.Location = Location;
            Top.Show();
            this.Hide();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }
    }
}
