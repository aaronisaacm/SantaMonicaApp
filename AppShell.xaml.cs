using SantaMonicaApp.Views;

namespace SantaMonicaApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(StreetsDetails), typeof(StreetsDetails));
        }
    }
}
