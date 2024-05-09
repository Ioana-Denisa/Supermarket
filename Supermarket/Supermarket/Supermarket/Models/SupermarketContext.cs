using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Supermarket.Models
{
    public partial class SupermarketContext : DbContext
    {
        public SupermarketContext()
        {
        }

        public SupermarketContext(DbContextOptions<SupermarketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Producers> Producers { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Stocks> Stocks { get; set; }
        public virtual DbSet<TicketProducts> TicketProducts { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=IOAANA\\SQLEXPRESS;Database=Supermarket;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Producers>(entity =>
            {
                entity.HasKey(e => e.IdProducer);

                entity.Property(e => e.IdProducer).HasColumnName("id_producer");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.Property(e => e.IdProduct).HasColumnName("id_product");

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.IdProducer).HasColumnName("id_producer");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_category");

                entity.HasOne(d => d.IdProducerNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdProducer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_producer");
            });

            modelBuilder.Entity<Stocks>(entity =>
            {
                entity.HasKey(e => e.IdStock);

                entity.Property(e => e.IdStock).HasColumnName("id_stock");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("expiration_date")
                    .HasColumnType("date");

                entity.Property(e => e.IdProduct).HasColumnName("id_product");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnName("purchase_price")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SellingPrice)
                    .HasColumnName("selling_price")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SupplyDate)
                    .HasColumnName("supply_date")
                    .HasColumnType("date");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_product");
            });

            modelBuilder.Entity<TicketProducts>(entity =>
            {
                entity.HasKey(e => new { e.IdTicket, e.IdProduct });

                entity.ToTable("Ticket_Products");

                entity.Property(e => e.IdTicket).HasColumnName("id_ticket");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("subtotal")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.TicketProducts)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_product_2");

                entity.HasOne(d => d.IdTicketNavigation)
                    .WithMany(p => p.TicketProducts)
                    .HasForeignKey(d => d.IdTicket)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_ticket");
            });

            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.HasKey(e => e.IdTicket);

                entity.Property(e => e.IdTicket).HasColumnName("id_ticket");

                entity.Property(e => e.IdCashier).HasColumnName("id_cashier");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("date");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdCashierNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.IdCashier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_cashier");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasColumnName("user_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
