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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTop = new Panel();
            btnBack = new Button();
            lblUserName = new Label();
            BtnLogUt = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvOrders = new DataGridView();
            panelTop.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnBack);
            panelTop.Controls.Add(lblUserName);
            panelTop.Controls.Add(BtnLogUt);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(0, 0, 0, 10);
            panelTop.Size = new Size(984, 40);
            panelTop.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumSpringGreen;
            btnBack.Dock = DockStyle.Left;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUserName.Location = new Point(852, 0);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Padding = new Padding(0, 13, 0, 0);
            lblUserName.Size = new Size(0, 34);
            lblUserName.TabIndex = 14;
            // 
            // BtnLogUt
            // 
            BtnLogUt.BackColor = Color.MediumSpringGreen;
            BtnLogUt.Dock = DockStyle.Right;
            BtnLogUt.FlatAppearance.BorderSize = 0;
            BtnLogUt.FlatStyle = FlatStyle.Flat;
            BtnLogUt.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnLogUt.ForeColor = Color.Black;
            BtnLogUt.Location = new Point(852, 0);
            BtnLogUt.Margin = new Padding(4);
            BtnLogUt.Name = "BtnLogUt";
            BtnLogUt.Size = new Size(132, 30);
            BtnLogUt.TabIndex = 13;
            BtnLogUt.Text = "Выход";
            BtnLogUt.UseVisualStyleBackColor = false;
            BtnLogUt.Click += BtnLogUt_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(6);
            flowLayoutPanel1.Size = new Size(984, 76);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.MediumSpringGreen;
            btnAdd.Dock = DockStyle.Left;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(10, 10);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(184, 51);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Добавить заказ";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.MediumSpringGreen;
            btnDelete.Dock = DockStyle.Left;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(202, 10);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(184, 51);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Удалить заказ";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 116);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(984, 545);
            dgvOrders.TabIndex = 13;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 661);
            Controls.Add(dgvOrders);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MinimumSize = new Size(525, 686);
            Name = "FormOrders";
            Text = "Заказы";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblUserName;
        private Button BtnLogUt;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnBack;
        private DataGridView dgvOrders;
    }
}