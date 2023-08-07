namespace KresticiNoliki
{
    partial class Top
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Down = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 434);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(33, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 315);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список лучших игроков:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.Down);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 60);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Exit.Image = global::KresticiNoliki.Properties.Resources.Cross;
            this.Exit.Location = new System.Drawing.Point(310, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // Down
            // 
            this.Down.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Down.Image = global::KresticiNoliki.Properties.Resources.Circle;
            this.Down.Location = new System.Drawing.Point(254, 3);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(50, 50);
            this.Down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Down.TabIndex = 1;
            this.Down.TabStop = false;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            this.Down.MouseEnter += new System.EventHandler(this.Down_MouseEnter);
            this.Down.MouseLeave += new System.EventHandler(this.Down_MouseLeave);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBox10.Image = global::KresticiNoliki.Properties.Resources.arrow;
            this.pictureBox10.Location = new System.Drawing.Point(12, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(97, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            this.pictureBox10.MouseEnter += new System.EventHandler(this.pictureBox10_MouseEnter);
            this.pictureBox10.MouseLeave += new System.EventHandler(this.pictureBox10_MouseLeave);
            // 
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 434);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Top";
            this.Text = "Top";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}