using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API.Models
{
    public partial class eakdbContext : DbContext
    {
        public eakdbContext()
        {
        }

        public eakdbContext(DbContextOptions<eakdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAluno> TbAluno { get; set; }
        public virtual DbSet<TbDisciplina> TbDisciplina { get; set; }
        public virtual DbSet<TbPonto> TbPonto { get; set; }
        public virtual DbSet<TbProfessor> TbProfessor { get; set; }
        public virtual DbSet<TbSerie> TbSerie { get; set; }
        public virtual DbSet<TbSerieAluno> TbSerieAluno { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;user id=root;password=1234;database=eakdb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAluno>(entity =>
            {
                entity.HasKey(e => e.IdAluno)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsSenha)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmAluno)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbDisciplina>(entity =>
            {
                entity.HasKey(e => e.IdDisciplina)
                    .HasName("PRIMARY");

                entity.Property(e => e.NmDisciplina)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbPonto>(entity =>
            {
                entity.HasKey(e => e.IdPonto)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdDisciplina)
                    .HasName("id_disciplina");

                entity.HasIndex(e => e.IdProfessor)
                    .HasName("id_professor");

                entity.HasIndex(e => e.IdSerieAluno)
                    .HasName("id_serie_aluno");

                entity.Property(e => e.DsObservacao)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdDisciplinaNavigation)
                    .WithMany(p => p.TbPonto)
                    .HasForeignKey(d => d.IdDisciplina)
                    .HasConstraintName("tb_ponto_ibfk_1");

                entity.HasOne(d => d.IdProfessorNavigation)
                    .WithMany(p => p.TbPonto)
                    .HasForeignKey(d => d.IdProfessor)
                    .HasConstraintName("tb_ponto_ibfk_3");

                entity.HasOne(d => d.IdSerieAlunoNavigation)
                    .WithMany(p => p.TbPonto)
                    .HasForeignKey(d => d.IdSerieAluno)
                    .HasConstraintName("tb_ponto_ibfk_2");
            });

            modelBuilder.Entity<TbProfessor>(entity =>
            {
                entity.HasKey(e => e.IdProfessor)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsSenha)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmProfessor)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbSerie>(entity =>
            {
                entity.HasKey(e => e.IdSerie)
                    .HasName("PRIMARY");

                entity.Property(e => e.NmSerie)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TpPeriodo)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbSerieAluno>(entity =>
            {
                entity.HasKey(e => e.IdSerieAluno)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdAluno)
                    .HasName("id_aluno");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.TbSerieAluno)
                    .HasForeignKey(d => d.IdAluno)
                    .HasConstraintName("tb_serie_aluno_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
