using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace KresticiNoliki
{
    public partial class Game : Form
    {
        int[] field = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Game()
        {
            InitializeComponent();
        }

        public void stepOFTHEPC(int[] field) 
        {
            int value = 10;
            int flag=0;
            for (int i = 0; i < 9; i++) { if (field[i] == 0) flag++; }
            if (flag==0) { return;}
            while (value == 10)
            {
                Random rnd = new Random();
                value = rnd.Next(0, 9);
                if (field[value] != 0) { value = 10; }
            }
            switch (value)
            {
                case 0: this.pictureBox1.Image = System.Drawing.Image.FromFile(@"..\..\images\Circle.png"); field[0] = 1; pictureBox1.Enabled = false; whoiswin(field); break;
                case 1: this.pictureBox2.Image = System.Drawing.Image.FromFile(@"..\..\images\Circle.png"); field[1] = 1; pictureBox2.Enabled = false; whoiswin(field); break;
                case 2: this.pictureBox3.Image = System.Drawing.Image.FromFile(@"..\..\images\Circle.png"); field[2] = 1; pictureBox3.Enabled = false; whoiswin(field); break;
                case 3: this.pictureBox4.Image = System.Drawing.Image.FromFile(@"..\..\images\Circle.png"); field[3] = 1; pictureBox4.Enabled = false; whoiswin(field); break;
                case 4: this.pictureBox5.Image = System.Drawing.Image.FromFile(@"..\..\images\Circle.png"); field[4] = 1; pictureBox5.Enabled = false; whoiswin(field); break;
                case 5: this.pictureBox6.Image = System.Drawing.Image.FromFile(@"..\..\images\Circle.png"); field[5] = 1; pictureBox6.Enabled = false; whoiswin(field); break;
                case 6: this.pictureBox7.Image = System.Drawing.Image.FromFile(@"..\..\images\Circle.png"); field[6] = 1; pictureBox7.Enabled = false; whoiswin(field); break;
                case 7: this.pictureBox8.Image = System.Drawing.Image.FromFile(@"..\..\images\Circle.png"); field[7] = 1; pictureBox8.Enabled = false; whoiswin(field); break;
                case 8: this.pictureBox9.Image = System.Drawing.Image.FromFile(@"..\..\images\Circle.png"); field[8] = 1; pictureBox9.Enabled = false; whoiswin(field); break;
            }
        }

        public bool whoiswin(int[] a)
        {
            if (a[0] == a[1] && a[0] == a[2] && a[0] == 1) 
            {
                winpage winpage = new winpage();
                winpage.LabelText = "Вы проиграли(";
                winpage.ShowDialog();
                return true;
            }
            else if (a[3] == a[4] && a[3] == a[5] && a[3] == 1) 
            {
                winpage winpage = new winpage();
                winpage.LabelText = "Вы проиграли(";
                winpage.ShowDialog();
                return true;
            }
            else if (a[6] == a[7] && a[6] == a[8] && a[6] == 1) 
            {
                winpage winpage = new winpage();
                winpage.LabelText = "Вы проиграли(";
                winpage.ShowDialog();
                return true;
            }
            else if (a[0] == a[3] && a[0] == a[6] && a[0] == 1) 
            {
                winpage winpage = new winpage();
                winpage.LabelText = "Вы проиграли(";
                winpage.ShowDialog();
                return true;
            }
            else if (a[1] == a[4] && a[1] == a[7] && a[1] == 1) 
            {
                winpage winpage = new winpage();
                winpage.LabelText = "Вы проиграли(";
                winpage.ShowDialog();
                return true;
            }
            else if (a[2] == a[5] && a[2] == a[8] && a[2] == 1) 
            {
                winpage winpage = new winpage();
                winpage.LabelText = "Вы проиграли(";
                winpage.ShowDialog();
                return true;
            }
            else if (a[0] == a[4] && a[0] == a[8] && a[0] == 1)
            {
                winpage winpage = new winpage();
                winpage.LabelText = "Вы проиграли(";
                winpage.ShowDialog();
                return true;
            }
            else if (a[2] == a[4] && a[2] == a[6] && a[2] == 1) 
            {
                winpage winpage = new winpage();
                winpage.LabelText = "Вы проиграли(";
                winpage.ShowDialog();
                return true;
            }
            else if (a[0] == a[1] && a[0] == a[2] && a[0] == 10) 
            {
                winpage winpage = new winpage();
                winpage.ShowDialog();
                return true;
            }
            else if (a[3] == a[4] && a[3] == a[5] && a[3] == 10) 
            {
                winpage winpage = new winpage();
                winpage.ShowDialog();
                return true;
            }
            else if (a[6] == a[7] && a[6] == a[8] && a[6] == 10)
            {
                winpage winpage = new winpage();
                winpage.ShowDialog();
                return true;
            }
            else if (a[0] == a[3] && a[0] == a[6] && a[0] == 10) 
            {
                winpage winpage = new winpage();
                winpage.ShowDialog();
                return true;
            }
            else if (a[1] == a[4] && a[1] == a[7] && a[1] == 10) 
            {
                winpage winpage = new winpage();
                winpage.ShowDialog();
                return true;
            }
            else if (a[2] == a[5] && a[2] == a[8] && a[2] == 10) 
            {
                winpage winpage = new winpage();
                winpage.ShowDialog();
                return true;
            }
            else if (a[0] == a[4] && a[0] == a[8] && a[0] == 10) 
            {
                winpage winpage = new winpage();
                winpage.ShowDialog();
                return true;
            }
            else if (a[2] == a[4] && a[2] == a[6] && a[2] == 10) 
            {
                winpage winpage = new winpage();
                winpage.ShowDialog();
                return true;
            }
            else if (a[0]!=0 && a[1]!=0 && a[2]!=0 && a[3] != 0 && a[4] != 0 && a[5] != 0 && a[6] != 0 && a[7] != 0 && a[8] != 0)
            {
                winpage winpage = new winpage();
                winpage.LabelText = "Это ничья(";
                winpage.ShowDialog();
                return true;
            }
            else return false;

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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Down_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Image = System.Drawing.Image.FromFile(@"..\..\images\Cross.png");
            field[0] = 10;
            whoiswin(field);
            pictureBox1.Enabled = false;
            if (whoiswin(field)==false)
                stepOFTHEPC(field);
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureBox2.Image = System.Drawing.Image.FromFile(@"..\..\images\Cross.png");
            field[1] = 10;
            whoiswin(field);
            pictureBox2.Enabled = false;
            if (whoiswin(field) == false)
                stepOFTHEPC(field);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureBox3.Image = System.Drawing.Image.FromFile(@"..\..\images\Cross.png");
            field[2] = 10;
            whoiswin(field);
            pictureBox3.Enabled = false;
            if (whoiswin(field) == false)
                stepOFTHEPC(field);
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureBox4.Image = System.Drawing.Image.FromFile(@"..\..\images\Cross.png");
            field[3] = 10;
            whoiswin(field);
            pictureBox4.Enabled = false;
            if (whoiswin(field) == false)
                stepOFTHEPC(field);
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureBox5.Image = System.Drawing.Image.FromFile(@"..\..\images\Cross.png");
            field[4] = 10;
            whoiswin(field);
            pictureBox5.Enabled = false;
            if (whoiswin(field) == false)
                stepOFTHEPC(field);
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureBox6.Image = System.Drawing.Image.FromFile(@"..\..\images\Cross.png");
            field[5] = 10;
            whoiswin(field);
            pictureBox6.Enabled = false;
            if (whoiswin(field) == false)
                stepOFTHEPC(field);
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureBox7.Image = System.Drawing.Image.FromFile(@"..\..\images\Cross.png");
            field[6] = 10;
            whoiswin(field);
            pictureBox7.Enabled = false;
            if (whoiswin(field) == false)
                stepOFTHEPC(field);
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureBox8.Image = System.Drawing.Image.FromFile(@"..\..\images\Cross.png");
            field[7] = 10;
            whoiswin(field);
            pictureBox8.Enabled = false;
            if (whoiswin(field) == false)
                stepOFTHEPC(field);
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureBox9.Image = System.Drawing.Image.FromFile(@"..\..\images\Cross.png");
            field[8] = 10;
            whoiswin(field);
            pictureBox9.Enabled = false;
            if (whoiswin(field) == false)
                stepOFTHEPC(field);
        }

        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            MenuForm1 window = new MenuForm1();
            window.StartPosition = FormStartPosition.Manual;
            window.Location = Location;
            window.Show();
            this.Hide();
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игроки по очереди ставят на свободные клетки поля 3×3 знаки (один всегда крестики, другой всегда нолики). Первый, выстроивший в ряд 3 своих фигуры по вертикали, горизонтали или большой диагонали, выигрывает. Если игроки заполнили все 9 ячеек и оказалось, что ни в одной вертикали, горизонтали или большой диагонали нет трёх одинаковых знаков, партия считается закончившейся в ничью. Первый ход делает игрок, ставящий крестики.");
        }
    }
}
