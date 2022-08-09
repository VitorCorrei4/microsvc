﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace microsvc.services.DbRepos.Order
{
    public partial class OrderEntity
    {
        public long Id { get; set; }
        public double? TotalSpent { get; set; }
        public long? UserId { get; set; }
    }
}
