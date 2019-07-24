using Checkins.Data.Entities;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkins.Data.EntityFramework.SqlServer
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Checkin>(etb => {
                etb.ToTable("Checkins");
                etb.HasKey(c => c.Id);
                etb.Property(c => c.Id).ValueGeneratedOnAdd();

                etb.Property(p => p.Location).HasMaxLength(225).IsRequired();
                etb.Property(p => p.Remark).HasMaxLength(100).IsRequired();


            });
        }
    }
}
