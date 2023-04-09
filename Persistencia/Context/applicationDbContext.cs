﻿using aplication.Interfaces;
using domain.Common;
using domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Context
{
    public class applicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        private readonly iDateTimeServices _dateTime;
        protected applicationDbContext(DbContextOptions<applicationDbContext> options, iDateTimeServices dateTime) 
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _dateTime = dateTime;
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entity in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.Created = _dateTime.NowUtc;
                        break;
                    case EntityState.Modified:
                        entity.Entity.LastModified = _dateTime.NowUtc;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }


    }
}
