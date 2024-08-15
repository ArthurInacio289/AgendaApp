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
    /// Classe de mapeamento para a entidade 'Tarefa'
    /// </summary>
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("TAREFA");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .HasColumnName("Id");//nome do campo

            builder.Property(t => t.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(50)//Máximo de caracteres
                .IsRequired();//not null (Obrigatório)

            builder.Property(t => t.Data)
                .HasColumnName("DATA")//nome do campo
                .HasColumnType("date")//tipo do campo
                .IsRequired();//not null (obrigatório)

            builder.Property(t => t.Hora)
                .HasColumnName("HORA")//nome do campo
                .HasColumnType("time")//tipo do campo
                .IsRequired();

            builder.Property(t => t.Prioridade)
                .HasColumnName("PRIORIDADE")//nome do campo
                .IsRequired();//not null (obrigatório)

            builder.Property(t => t.CategoriaId)
                .HasColumnName("CATEGORIAID")//nome do campo
                .IsRequired();

            //mapeamento do relacionamento
            builder.HasOne(t => t.Categoria)//tarefa TEM 1 categoria
                .WithMany(c => c.tarefas) //categoria TEM MUITAS tarefas
                .HasForeignKey(t => t.CategoriaId); //Chave estrangeira 



        }

        
    }
}
