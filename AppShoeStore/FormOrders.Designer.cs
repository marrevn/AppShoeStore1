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
            label1 = new Label();
            button3 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(317, 27);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 5;
            label1.Text = "ФИО пользователя";
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSpringGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(486, 12);
            button3.Name = "button3";
            button3.Size = new Size(103, 50);
            button3.TabIndex = 4;
            button3.Text = "ВЫХОД";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSpringGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(4, 12);
            button1.Name = "button1";
            button1.Size = new Size(103, 50);
            button1.TabIndex = 6;
            button1.Text = "НАЗАД";
            button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Location = new Point(1, 82);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(604, 74);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.MediumSpringGreen;
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(145, 50);
            button2.TabIndex = 7;
            button2.Text = "Добавить заказ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.MediumSpringGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(154, 3);
            button4.Name = "button4";
            button4.Size = new Size(163, 50);
            button4.TabIndex = 8;
            button4.Text = "Редактировать";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.MediumSpringGreen;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(323, 3);
            button5.Name = "button5";
            button5.Size = new Size(156, 50);
            button5.TabIndex = 9;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = false;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 511);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button3);
            Name = "FormOrders";
            Text = "Заказы";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}