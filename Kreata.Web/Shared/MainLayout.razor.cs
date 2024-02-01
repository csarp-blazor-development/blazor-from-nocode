namespace Kreata.Web.Shared
{
    public partial class MainLayout
    {
        private bool _drawerOpen = true;
        private bool _isCurrentLightTheme = true;
        private void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}