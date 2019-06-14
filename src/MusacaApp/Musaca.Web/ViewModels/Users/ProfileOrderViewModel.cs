﻿using System;

namespace Musaca.App.ViewModels.Users
{
    public class ProfileOrderViewModel
    {
        public string Id { get; set; }

        public decimal Total { get; set; }

        public DateTime IssuedOn { get; set; }

        public string Cashier { get; set; }
    }
}
