using Klijent.GuiControllers;

namespace Klijent
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            MainCoordinator.Instance.ShowFrmGlavna();
        }
    }
}