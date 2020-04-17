using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.DataAccess.Concrete.EntityFramework.Mappings
{
    public class YetkiMap : IEntityTypeConfiguration<Yetki>
    {
        public void Configure(EntityTypeBuilder<Yetki> builder)
        {
            builder.ToTable(@"Yetkiler", "dbo");
            builder.HasKey(x => x.id);

            builder.Property(x => x.id).HasColumnName("id");
            builder.Property(x => x.yetki_adi).HasColumnName("yetki_adi");
            builder.Property(x => x.ekleyen_id).HasColumnName("ekleyen_id");
            builder.Property(x => x.eklenme_tarihi).HasColumnName("eklenme_tarihi");
            builder.Property(x => x.sil_id).HasColumnName("sil_id");
            builder.Property(x => x.guncelleyen_id).HasColumnName("guncelleyen_id");
            builder.Property(x => x.guncelleme_tarihi).HasColumnName("guncelleme_tarihi");
        }
    }
}
