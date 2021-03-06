﻿using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Persistence.Configuration;

namespace Persistence {
    public class NnaContext : IdentityDbContext<NnaUser, NnaRole, Guid> {

        public DbSet<NnaUser> ApplicationUsers { get; set; }
        public DbSet<Dmo> Dmos { get; set; }
        public DbSet<DmoCollection> DmoCollections { get; set; }

        public NnaContext() { }

        public NnaContext(DbContextOptions<NnaContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            DmoConfiguration.Configure(modelBuilder);
            UserDmoCollectionConfiguration.Configure(modelBuilder);
            DmoUserDmoCollectionConfiguration.Configure(modelBuilder);
        }
    }
}
