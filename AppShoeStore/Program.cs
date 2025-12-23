using AppShoeStore.Models;

namespace AppShoeStore
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
                using(var formLogin=new FormAvtoriz())
                {
                    if(formLogin.ShowDialog() == DialogResult.OK)
                    {
                        using(var formProducts = new FormProducts(
                            formLogin.CurrentUser,
                            formLogin.IsGuest))
                        {
                            if(formProducts.ShowDialog() == DialogResult.Cancel)
                            {
                                continue;
                            }
                            else
                            {
                                exitProgram = true;
                            }
                        }
                    }
                    else
                    {
                        exitProgram = true;
                    }
                }
            }
        }
    }
}