using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lazuli.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lazuli.Api.Data.Mappings
{
    public class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.Property(x => x.Title)
                .IsRequired(true)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Type)
                .IsRequired(true)
                .HasColumnType("SMALLINT");

            builder.Property(x => x.Amount)
                .IsRequired(true)
                .HasColumnType("MONEY");

            builder.Property(x => x.createdAt)
                .IsRequired(true);

            builder.Property(x => x.PaidOrReceivedAt)
                .IsRequired(false);

            builder.Property(x => x.UserId)
                .IsRequired(true)
                .HasColumnType("VARCHAR")
                .HasMaxLength(160);
        }
    }
}