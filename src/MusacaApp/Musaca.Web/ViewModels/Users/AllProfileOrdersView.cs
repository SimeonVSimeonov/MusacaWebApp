using System;
using System.Collections.Generic;
using System.Text;

namespace Musaca.App.ViewModels.Users
{
    public class AllProfileOrdersView
    {
        public AllProfileOrdersView()
        {
            this.ProfileOrderViewModel = new List<ProfileOrderViewModel>();
        }

        public List<ProfileOrderViewModel> ProfileOrderViewModel { get; set; }
    }
}
