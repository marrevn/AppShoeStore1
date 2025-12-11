namespace AppShoeStore
{
    partial class FormMenu
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
            panel1 = new Panel();
            label1 = new Label();
            button3 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(601, 68);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(325, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(163, 48);
            label1.TabIndex = 14;
            label1.Text = "ФИО пользователя";
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSpringGreen;
            button3.Dock = DockStyle.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(488, 10);
            button3.Name = "button3";
            button3.Size = new Size(103, 48);
            button3.TabIndex = 13;
            button3.Text = "ВЫХОД";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 100, 10, 0);
            panel2.Size = new Size(601, 443);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSpringGreen;
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(10, 150);
            button2.Name = "button2";
            button2.Size = new Size(581, 50);
            button2.TabIndex = 3;
            button2.Text = "ТОВАРЫ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSpringGreen;
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(10, 100);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Size = new Size(581, 50);
            button1.TabIndex = 2;
            button1.Text = "ЗАКАЗЫ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMenu";
            Text = "Меню";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button button3;
        private Panel panel2;
        private Button button2;
        private Button button1;
    }
}