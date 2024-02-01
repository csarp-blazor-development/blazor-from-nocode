namespace Kreata.Web.Shared
{
    public partial class MainLayout
    {
        bool _drawerOpen = true;
        private void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}