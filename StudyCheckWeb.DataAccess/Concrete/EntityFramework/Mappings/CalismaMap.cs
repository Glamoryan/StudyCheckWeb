using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CalismaMap : IEntityTypeConfiguration<Calisma>
    {
        public void Configure(EntityTypeBuilder<Calisma> builder)
        {
            builder.ToTable(@"Calismalar", "dbo");
            builder.HasKey(x => x.id);

            builder.Property(x => x.id).HasColumnName("id");
            builder.Property(x => x.uye_id).HasColumnName("uye_id");
            builder.Property(x => x.sinav_id).HasColumnName("sinav_id");
            builder.Property(x => x.ders_id).HasColumnName("ders_id");
            builder.Property(x => x.calisilan_zaman).HasColumnName("calisilan_zaman");
            builder.Property(x => x.calisilan_tarih).HasColumnName("calisilan_tarih");
        }
    }
}
