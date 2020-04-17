using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.DataAccess.Concrete.EntityFramework.Mappings
{
    public class RolMap : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable(@"Roller", "dbo");
            builder.HasKey(x => x.id);

            builder.Property(x => x.id).HasColumnName("id");
            builder.Property(x => x.rol_adi).HasColumnName("rol_adi");
            builder.Property(x => x.rol_kayit_tarihi).HasColumnName("rol_kayit_tarihi");
            builder.Property(x => x.ekleyen_id).HasColumnName("ekleyen_id");
            builder.Property(x => x.rol_guncelleme_tarihi).HasColumnName("rol_guncelleme_tarihi");
            builder.Property(x => x.sil_id).HasColumnName("sil_id");
            builder.Property(x => x.yetki_id).HasColumnName("yetki_id");
            builder.Property(x => x.guncelleyen_id).HasColumnName("guncelleyen_id");
        }
    }
}
