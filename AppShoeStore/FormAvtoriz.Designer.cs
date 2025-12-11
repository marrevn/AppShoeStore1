namespace AppShoeStore
{
    partial class FormAvtoriz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvtoriz));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 10, 20, 10);
            panel1.Size = new Size(601, 140);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(561, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 411);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(70, 10, 70, 10);
            panel3.Size = new Size(601, 100);
            panel3.TabIndex = 10;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(70, 13);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(461, 38);
            button1.TabIndex = 18;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Dock = DockStyle.Bottom;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(70, 51);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(461, 39);
            button2.TabIndex = 17;
            button2.Text = "Войти как гость";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 140);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 20, 20, 0);
            panel2.Size = new Size(601, 271);
            panel2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(20, 147);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(561, 45);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(20, 106);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 10, 5, 10);
            label2.Size = new Size(83, 41);
            label2.TabIndex = 12;
            label2.Text = "Пароль:";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(20, 61);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(561, 45);
            textBox2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 10, 5, 10);
            label1.Size = new Size(75, 41);
            label1.TabIndex = 6;
            label1.Text = "Логин:";
            // 
            // FormAvtoriz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 511);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FormAvtoriz";
            Text = "Авторизация";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
    }
}
