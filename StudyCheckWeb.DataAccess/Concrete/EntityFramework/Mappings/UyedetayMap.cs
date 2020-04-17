using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UyedetayMap : IEntityTypeConfiguration<Uyedetay>
    {
        public void Configure(EntityTypeBuilder<Uyedetay> builder)
        {
            builder.ToTable(@"UyeDetay", "dbo");
            builder.HasKey(x => x.id);

            builder.Property(x => x.id).HasColumnName("id");
            builder.Property(x => x.uye_id).HasColumnName("uye_id");
            builder.Property(x => x.kullanici_adi).HasColumnName("kullanici_adi");
            builder.Property(x => x.kullanici_sifre).HasColumnName("kullanici_sifre");
            builder.Property(x => x.kullanici_mail).HasColumnName("kullanici_mail");
            builder.Property(x => x.kayit_tarihi).HasColumnName("kayit_tarihi");
            builder.Property(x => x.guncelleme_tarihi).HasColumnName("guncelleme_tarihi");
            builder.Property(x => x.sil_id).HasColumnName("sil_id");
            builder.Property(x => x.tema_id).HasColumnName("tema_id");
            builder.Property(x => x.rol_id).HasColumnName("rol_id");
            builder.Property(x => x.guncelleyen_id).HasColumnName("guncelleyen_id");
        }
    }
}
