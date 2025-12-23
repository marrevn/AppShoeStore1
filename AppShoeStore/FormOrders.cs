using AppShoeStore.Models;
using AppShoeStore.Properties;
using Microsoft.EntityFrameworkCore;
namespace AppShoeStore
{
    public partial class FormOrders : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormOrders(User user, bool guest)
        {
            InitializeComponent();

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 80;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDelivery = new DataGridViewTextBoxColumn();
            colDelivery.Name = "colDelivery";
            colDelivery.FillWeight = 20;
            colDelivery.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgOrders.Columns.AddRange(
            [
                colInfo, colDelivery
            ]);

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadOrders();
        }
        private void LoadOrders()
        {
            try
            {
                using (var db = new Models.ShopDbContext())
                {
                    var orders = db.ProductsOrders
                        .Include(i => i.IdProduct)
                        .Include(i => i.IdOrder)
                        .Include(i => i.)
                        .Include(i => i.)
                        .Include(i => i.)
                        .ToList();
                    dvgOrders.SuspendLayout();
                    dvgOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        int rowIndex = dvgOrders.Rows.Add();
                        var row = dvgOrders.Rows[rowIndex];

                        row.Cells["colInfo"].Value = FormatOrderInfo(orders);

                        row.Cells["colDelivery"].Value = $"{orders.DeliveryDate}";
                        row.Cells["colDiscount"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    }
                    dvgOrders.ResumeLayout();
                    dvgOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private string FormatOrderInfo(Product product)
        {
            return $"{product.Category.CategoryName} | {product.ProductType.ProdType}" + Environment.NewLine +
                $"Артикулы: {product.Description}" + Environment.NewLine +
                $"Статус заказа: {product.Manufacturer.ManufacturerName}" + Environment.NewLine +
                $"Адрес пункта выдачи: {product.Supplier.SupplierName}" + Environment.NewLine +
                $"Дата заказа: {product.Measure}";



        }

        private void BtnLogut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            FormOrderManagement formOrdersManagement = new FormOrderManagement();
            formOrdersManagement.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
