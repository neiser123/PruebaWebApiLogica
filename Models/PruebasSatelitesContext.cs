using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace logica.Models
{
    public partial class PruebasSatelitesContext : DbContext
    {


        //public static PruebasSatelitesContext _context;

        public PruebasSatelitesContext()
        {
        }

        public PruebasSatelitesContext(DbContextOptions<PruebasSatelitesContext> options)
            : base(options)
        {
        }
   
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Coverphotos> Coverphotos { get; set; }
        public virtual DbSet<Users> Users { get; set; }

 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source=DESKTOP-68CSEVF; Initial Catalog=PruebasSatelites; user id=sa; password=1234;");
            }
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activities>(entity =>
            {
                entity.ToTable("activities");

                entity.Property(e => e.id)
                    .HasColumnName("id")
                    .HasColumnType("bigint")
                    .ValueGeneratedNever();

                entity.Property(e => e.completed)
                    .HasColumnName("completed")
                    .HasMaxLength(10);

                entity.Property(e => e.dueDate).HasColumnName("dueDate");

                entity.Property(e => e.title).HasColumnName("title");
            });

            modelBuilder.Entity<Authors>(entity =>
            {
                entity.ToTable("authors");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasColumnName("firstName");

                entity.Property(e => e.IdBook).HasColumnName("idBook");

                entity.Property(e => e.LastName).HasColumnName("lastName");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.ToTable("books");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Excerpt).HasColumnName("excerpt");

                entity.Property(e => e.PageCount).HasColumnName("pageCount");

                entity.Property(e => e.PublishDate)
                    .HasColumnName("publishDate")
                    .HasMaxLength(50);

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<Coverphotos>(entity =>
            {
                entity.ToTable("coverphotos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdBook)
                    .HasColumnName("idBook")
                    .HasMaxLength(50);

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.UserName).HasColumnName("userName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        //patron singleton 
    }
}
