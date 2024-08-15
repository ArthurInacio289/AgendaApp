using AgendaApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Data.Mappings
{
    /// <summary>
    /// Classe de mapeamento para categoria 
    /// </summary>
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria>builder)
        {
            //nome da categoria 
            builder.ToTable("Categoria");
            //definindo o campo 'chave primária'
            builder.HasKey(x => x.Id);

            //mapeando o campo 'Id'
            builder.Property(x => x.Id)
                .HasColumnName("Id");//nome da coluna

            builder.Property(x => x.Descricao)
               .HasColumnName("DESCRICAO")//nome da coluna
               .HasMaxLength(50)//max de caracteres
               .IsRequired();//not null (required) 

        }

    }
}
