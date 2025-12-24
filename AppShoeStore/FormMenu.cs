using AppShoeStore.Models;
using Microsoft.VisualBasic.ApplicationServices;
using User = AppShoeStore.Models.User;

namespace AppShoeStore
{
    public partial class FormMenu : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormMenu(User user, bool guest)
        {
            InitializeComponent();

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            btnOrders.Visible = !IsGuest;
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var formOrders = new FormOrders(CurrentUser))
            {
                formOrders.ShowDialog();
                this.Show();
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var formProducts = new FormProducts(CurrentUser, IsGuest))
            {
                formProducts.ShowDialog();
                this.Show();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
