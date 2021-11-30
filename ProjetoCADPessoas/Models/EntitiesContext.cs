using Microsoft.EntityFrameworkCore;

namespace ProjetoCADPessoas.Models
{
    public partial class EntitiesContext : DbContext
    {
        public EntitiesContext(DbContextOptions<EntitiesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<endereco> endereco { get; set; }
        public virtual DbSet<pessoa> pessoa { get; set; }
        public virtual DbSet<pessoa_telefone> pessoa_telefone { get; set; }
        public virtual DbSet<telefone> telefone { get; set; }
        public virtual DbSet<telefone_tipo> telefone_tipo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user id=root;password=duda;database=cadastropessoa;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<endereco>(entity =>
            {
                entity
                    .HasKey(e => e.id_endereco)
                    .HasName("PRIMARY");
                entity
                    .Property(e => e.id_endereco)
                    .HasColumnName("id_endereco")
                    .ValueGeneratedOnAdd();
                entity
                    .Property(e => e.logradouro)
                    .IsRequired()
                    .HasColumnName("logradouro")
                    .HasMaxLength(256);
                entity
                    .Property(e => e.numero)
                    .IsRequired()
                    .HasColumnName("numero");
                entity
                    .Property(e => e.cep)
                    .IsRequired()
                    .HasColumnName("cep");
                entity
                    .Property(e => e.bairro)
                    .IsRequired()
                    .HasColumnName("bairro")
                    .HasMaxLength(50);
                entity
                    .Property(e => e.cidade)
                    .IsRequired()
                    .HasColumnName("cidade")
                    .HasMaxLength(30);
                entity
                    .Property(e => e.estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(20);
                entity
                    .ToTable("endereco");
            });

            modelBuilder.Entity<pessoa>(entity =>
            {
                entity
                    .HasKey(e => e.id_pessoa)
                    .HasName("PRIMARY");
                entity
                    .Property(e => e.id_pessoa)
                    .HasColumnName("id_pessoa")
                    .ValueGeneratedOnAdd();
                entity
                    .Property(e => e.nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(256);
                entity
                    .Property(e => e.cpf)
                    .IsRequired()
                    .HasColumnName("cpf");
                entity
                    .Property(e => e.id_endereco)
                    .HasColumnName("id_endereco");
                entity
                    .HasOne(d => d.endereco)
                    .WithMany(p => p.pessoa)
                    .HasForeignKey(d => d.id_endereco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("end_pes_fk");
                entity
                    .HasIndex(e => e.id_endereco)
                    .HasName("end_pes_fk_idx");
                entity
                    .ToTable("pessoa");
            });

            modelBuilder.Entity<pessoa_telefone>(entity =>
            {
                entity
                    .HasKey(e => new { e.id_pessoa, e.id_telefone })
                    .HasName("PRIMARY");
                entity
                    .Property(e => e.id_pessoa)
                    .HasColumnName("id_pessoa");
                entity
                    .Property(e => e.id_telefone)
                    .HasColumnName("id_telefone");
                entity
                    .HasIndex(e => e.id_pessoa)
                    .HasName("pes_pes_tel_fk_idx");
                entity
                    .ToTable("pessoa_telefone");
            });

            modelBuilder.Entity<telefone>(entity =>
            {
                entity
                    .HasKey(e => e.id_telefone)
                    .HasName("PRIMARY");
                entity
                    .Property(e => e.id_telefone)
                    .HasColumnName("id_telefone")
                    .ValueGeneratedOnAdd();
                entity
                    .Property(e => e.numero)
                    .IsRequired()
                    .HasColumnName("numero");
                entity
                    .Property(e => e.ddd)
                    .IsRequired()
                    .HasColumnName("ddd");
                entity
                    .Property(e => e.id_telefone_tipo)
                    .HasColumnName("id_telefone_tipo");
                entity
                    .HasOne(d => d.telefone_tipo)
                    .WithMany(p => p.telefone)
                    .HasForeignKey(d => d.id_telefone_tipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tel_tip_tel_fk");
                entity
                    .HasIndex(e => e.id_telefone_tipo)
                    .HasName("tel_tip_tel_fk_idx");
                entity
                    .ToTable("telefone");
            });

            modelBuilder.Entity<telefone_tipo>(entity =>
            {
                entity
                    .HasKey(e => e.id_telefone_tipo)
                    .HasName("PRIMARY");
                entity
                    .Property(e => e.id_telefone_tipo)
                    .HasColumnName("id_telefone_tipo")
                    .ValueGeneratedOnAdd();
                entity
                    .Property(e => e.tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(10);
                entity
                    .ToTable("telefone_tipo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
