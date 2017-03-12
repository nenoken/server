﻿using System;

namespace Bit.Core.Models.Data
{
    public class SubvaultUserDetails
    {
        public Guid Id { get; set; }
        public Guid OrganizationUserId { get; set; }
        public string Name { get; set; }
        public Guid SubvaultId { get; set; }
        public bool ReadOnly { get; set; }
        public bool Admin { get; set; }
    }
}
