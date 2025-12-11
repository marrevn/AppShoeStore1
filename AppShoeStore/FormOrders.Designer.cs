namespace AppShoeStore
{
    partial class FormOrders
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
            button3 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            button5 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSpringGreen;
            button3.Dock = DockStyle.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(491, 10);
            button3.Name = "button3";
            button3.Size = new Size(103, 48);
            button3.TabIndex = 4;
            button3.Text = "ВЫХОД";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSpringGreen;
            button1.Dock = DockStyle.Left;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(10, 10);
            button1.Name = "button1";
            button1.Size = new Size(103, 48);
            button1.TabIndex = 6;
            button1.Text = "НАЗАД";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 165);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(604, 346);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(584, 109);
            panel3.TabIndex = 0;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.MediumSpringGreen;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(11, 11);
            button5.Name = "button5";
            button5.Size = new Size(156, 50);
            button5.TabIndex = 9;
            button5.Text = "Добавить заказ";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(604, 68);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(328, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(163, 48);
            label1.TabIndex = 7;
            label1.Text = "ФИО пользователя";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(button5);
            flowLayoutPanel3.Controls.Add(button2);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 68);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(8);
            flowLayoutPanel3.Size = new Size(604, 97);
            flowLayoutPanel3.TabIndex = 11;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.MediumSpringGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(173, 11);
            button2.Name = "button2";
            button2.Size = new Size(156, 50);
            button2.TabIndex = 10;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Size = new Size(391, 89);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Right;
            label4.Location = new Point(448, 10);
            label4.Name = "label4";
            label4.Size = new Size(126, 89);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(604, 511);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(412, 550);
            Name = "FormOrders";
            Text = "Заказы";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button button1;
        private Panel panel1;
        private Button button5;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button2;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private Label label3;
    }
}