using AppShoeStore.Models;
using AppShoeStore.Properties;
using Microsoft.EntityFrameworkCore;
namespace AppShoeStore
{
    public partial class FormOrders : Form
    {
        public User CurrentUser { get; private set; }
        public FormOrders(User user)
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

            dgvOrders.Columns.AddRange(
            [
                colInfo, colDelivery
            ]);

            CurrentUser = user;

            lblUserName.Text = CurrentUser.FullName;

            LoadOrders();
        }
        private void LoadOrders()
        {
            try
            {
                using (var db = new Models.ShopDbContext())
                {
                    var orders = db.Orders
                        .Include(i => i.ProductsOrders)
                            .ThenInclude(i => i.Product)
                        .Include(i => i.Status)
                        .Include(i => i.DeliveryPoint)
                        .Where(o => o.IdUser == CurrentUser.Id)
                        .ToList();
                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {

                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["colInfo"].Value = FormatOrderInfo(order);
                        row.Cells["colDelivery"].Value = $"{order.DeliveryDate}";

                    }
                    dgvOrders.ResumeLayout();
                    dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private string FormatOrderInfo(Order order)
        {
            var articleNumbers = order.ProductsOrders
                .Select(po => po.Product.Art)
                .ToArray();
            string articlesString = string.Join(", ", articleNumbers);

            return $"Артикулы: {articlesString}" + Environment.NewLine +
            $"Статус заказа: {order.Status.StatusName}" + Environment.NewLine +
            $"Адрес пункта выдачи: {order.DeliveryPoint.DeliveryAddress}" + Environment.NewLine +
            $"Дата доставки: {order.DeliveryDate}";
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogUt_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
