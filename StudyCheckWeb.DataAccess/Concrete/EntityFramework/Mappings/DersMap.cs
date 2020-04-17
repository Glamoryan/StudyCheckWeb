using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.DataAccess.Concrete.EntityFramework.Mappings
{
    public class DersMap : IEntityTypeConfiguration<Ders>
    {
        public void Configure(EntityTypeBuilder<Ders> builder)
        {
            builder.ToTable(@"Dersler", "dbo");
            builder.HasKey(x => x.id);

            builder.Property(x => x.id).HasColumnName("id");
            builder.Property(x => x.sinav_id).HasColumnName("sinav_id");
            builder.Property(x => x.ders_ad).HasColumnName("ders_ad");
            builder.Property(x => x.eklenme_tarihi).HasColumnName("eklenme_tarihi");
            builder.Property(x => x.ekleyen_id).HasColumnName("ekleyen_id");
            builder.Property(x => x.guncelleme_tarihi).HasColumnName("guncelleme_tarihi");
            builder.Property(x => x.sil_id).HasColumnName("sil_id");
            builder.Property(x => x.guncelleyen_id).HasColumnName("guncelleyen_id");
        }
    }
}
