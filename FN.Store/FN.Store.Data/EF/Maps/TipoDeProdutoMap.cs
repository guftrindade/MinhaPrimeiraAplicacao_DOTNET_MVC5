using FN.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FN.Store.Data.EF.Maps
{
    public class TipoDeProdutoMap: EntityTypeConfiguration<TipoDeProduto>
    {
        public TipoDeProdutoMap()
        {
            //Table
            ToTable(nameof(TipoDeProduto));

            //PK
            HasKey(pk => pk.id);

            //Columns
            Property(c => c.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.DataCadastro);
        }
    }
}
