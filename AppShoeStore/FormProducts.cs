using AppShoeStore.Models;
using Microsoft.EntityFrameworkCore;

namespace AppShoeStore
{
    public partial class FormProducts : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormProducts(User user, bool guest)
        {
            InitializeComponent();

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;

            var colInfo= new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode=DataGridViewTriState.True;

            var colDiscount= new DataGridViewTextBoxColumn();
            colDiscount.Name = "colDiscount";
            colDiscount.FillWeight = 10;
            colDiscount.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.Columns.AddRange(
            [
                colPhoto,colInfo, colDiscount
            ]);

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость:" : CurrentUser.Fullname;

            LoadProducts();
        }
        private void LoadProducts()
        {
            try
            {
                using (var db = new Models.AppContext())
                {
                    var products = db.Products
                        .Include(i => i.Category)
                        .Include(i => i.Manufacturer)
                        .Include(i => i.Supplier)
                        //.Include(i => i.Measure)
                        .ToList();
                    dgvProducts.SuspendLayout();
                    dgvProducts.Rows.Clear();

                    foreach (var product in products)
                    {
                        int rowIndex = dgvProducts.Rows.Add();
                        var row = dgvProducts.Rows[rowIndex];

                        row.Cells["colPhoto"].Value = LoadProductImage(product.Picture);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Image LoadProductImage(string picture)
        {
            if (!String.IsNullOrEmpty(picture) && System.IO.File.Exists(picture))
            {
                return Image.FromFile(picture);
            }
           // здесь остановилась время 1.16.09
        //    Bitmap bmp = new Bitmap(150, 100);
        //    using (Graphics g=Graphics.FromImage(bmp))
        //    {
        //        g.Clear(Color.White);
        //        g.DrawRectangle(Pens.LightGray, 0, 0, 149, 999);

        //    }
        //    return 
        //}

    }
}
