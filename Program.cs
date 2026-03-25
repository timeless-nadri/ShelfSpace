using ShelfSpace.Data;
using ShelfSpace.Forms;

namespace ShelfSpace
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            DatabaseHelper.InitializeDatabase();

            if (!DatabaseHelper.UserExists())
            {
                Application.Run(new FirstRunForm());
            }
            else
            {
                Application.Run(new StartForm());
            }
        }
    }
}