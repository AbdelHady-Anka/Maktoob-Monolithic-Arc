﻿using System;

namespace Maktoob.Domain.Entities
{
    public class UserProfile : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Photo ProfilePhoto { get; set; }
        public Photo CoverPhoto { get; set; }
        public Location Location { get; set; }
    }
}