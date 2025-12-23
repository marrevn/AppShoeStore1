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
            btnBack = new Button();
            label1 = new Label();
            btnExit = new Button();
            panel2 = new Panel();
            btnProducts = new Button();
            btnOrders = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(773, 40);
            panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumSpringGreen;
            btnBack.Dock = DockStyle.Left;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(0, 0);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(132, 30);
            btnBack.TabIndex = 15;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(641, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 13, 0, 0);
            label1.Size = new Size(0, 34);
            label1.TabIndex = 14;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.MediumSpringGreen;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(641, 0);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 30);
            btnExit.TabIndex = 13;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProducts);
            panel2.Controls.Add(btnOrders);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(13, 127, 13, 0);
            panel2.Size = new Size(773, 607);
            panel2.TabIndex = 3;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.MediumSpringGreen;
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Times New Roman", 12F);
            btnProducts.ForeColor = Color.Black;
            btnProducts.Location = new Point(13, 190);
            btnProducts.Margin = new Padding(4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(747, 63);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "ТОВАРЫ";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.MediumSpringGreen;
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Times New Roman", 12F);
            btnOrders.ForeColor = Color.Black;
            btnOrders.Location = new Point(13, 127);
            btnOrders.Margin = new Padding(13);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(747, 63);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "ЗАКАЗЫ";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += BtnOrders_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(773, 647);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMenu";
            Text = "Меню";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btnExit;
        private Panel panel2;
        private Button btnProducts;
        private Button btnOrders;
        private Button btnBack;
    }
}