using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TemaMap : IEntityTypeConfiguration<Tema>
    {
        public void Configure(EntityTypeBuilder<Tema> builder)
        {
            builder.ToTable(@"Temalar", "dbo");
            builder.HasKey(x => x.id);

            builder.Property(x => x.id).HasColumnName("id");
            builder.Property(x => x.tema_adi).HasColumnName("tema_adi");
            builder.Property(x => x.eklenme_tarihi).HasColumnName("eklenme_tarihi");
            builder.Property(x => x.ekleyen_id).HasColumnName("ekleyen_id");
            builder.Property(x => x.sil_id).HasColumnName("sil_id");
        }
    }
}
