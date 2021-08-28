using EA_Dashboard.Models;
using EA_Dashboard.ViewModels;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;

namespace EA_Dashboard.Utils
{
    public static class NavigationManager
    {
        private static MainWindowViewModel dataContext;

        public static List<DrawerMenuItem> GetDrawerMenuItems()
        {
            return new List<DrawerMenuItem>()
            {
                new DrawerMenuItem(){Name = "Campioni", Icon = PackIconKind.ClipboardListOutline},
                new DrawerMenuItem(){Name = "Fatture", Icon = PackIconKind.Bookshelf},
                new DrawerMenuItem(){Name = "Gestione DDT", Icon = PackIconKind.BookOpen},
                new DrawerMenuItem(){Name = "Statistiche", Icon = PackIconKind.Tune },
                new DrawerMenuItem(){Name = "Query", Icon = PackIconKind.Database },
                new DrawerMenuItem(){Name = "Impostazioni", Icon = PackIconKind.Cog },
                new DrawerMenuItem(){Name = "Email", Icon = PackIconKind.Email },
            };
        }
    }
}
