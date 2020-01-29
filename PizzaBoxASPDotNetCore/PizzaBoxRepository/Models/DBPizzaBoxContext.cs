using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaBoxRepository.Models
{
    public partial class DBPizzaBoxContext : DbContext
    {
        public DBPizzaBoxContext()
        {
        }

        public DBPizzaBoxContext(DbContextOptions<DBPizzaBoxContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=DBPizzaBox;Trusted_Connection=True;");
            }
        }


        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<PizzaOrder> PizzaOrder { get; set; }
        public virtual DbSet<PizzaUser> PizzaUser { get; set; }
        public virtual DbSet<Store> Store { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Pizza__DD37D91A92026F02");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Bacon).HasColumnName("bacon");

                entity.Property(e => e.Cheese)
                    .HasColumnName("cheese")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Chicken).HasColumnName("chicken");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("money");

                entity.Property(e => e.Crust)
                    .IsRequired()
                    .HasColumnName("crust")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraCheese).HasColumnName("extra_cheese");

                entity.Property(e => e.Mozzerella).HasColumnName("mozzerella");

                entity.Property(e => e.Onion).HasColumnName("onion");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Pepper).HasColumnName("pepper");

                entity.Property(e => e.Pepperoni).HasColumnName("pepperoni");

                entity.Property(e => e.Pineapple).HasColumnName("pineapple");

                entity.Property(e => e.Sauce)
                    .HasColumnName("sauce")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sausage).HasColumnName("sausage");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasColumnName("size")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Pizza)
                    .HasForeignKey(d => d.Orderid)
                    .HasConstraintName("FK_PizzaOrder");
            });

            modelBuilder.Entity<PizzaOrder>(entity =>
            {
                entity.HasKey(e => e.Orderid)
                    .HasName("PK__PizzaOrd__080E37752161D0FF");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("money");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Storename)
                    .IsRequired()
                    .HasColumnName("storename")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.StorenameNavigation)
                    .WithMany(p => p.PizzaOrder)
                    .HasForeignKey(d => d.Storename)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PizzaOrde__store__3D5E1FD2");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PizzaOrder)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PizzaOrde__usern__3C69FB99");
            });

            modelBuilder.Entity<PizzaUser>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__PizzaUse__F3DBC5737D635ECA");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cell)
                    .IsRequired()
                    .HasColumnName("cell")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserAddress)
                    .IsRequired()
                    .HasColumnName("user_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserJoinDate)
                    .HasColumnName("user_join_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("user_password")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.Storename)
                    .HasName("PK__Store__AEF30AB5BE58A80A");

                entity.Property(e => e.Storename)
                    .HasColumnName("storename")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cell)
                    .IsRequired()
                    .HasColumnName("cell")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PresetPizzaId).HasColumnName("preset_pizza_ID");

                entity.Property(e => e.PresetSpecial)
                    .HasColumnName("preset_special")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddress)
                    .IsRequired()
                    .HasColumnName("store_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreJoinDate)
                    .HasColumnName("store_join_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StorePassword)
                    .IsRequired()
                    .HasColumnName("store_password")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.PresetPizza)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.PresetPizzaId)
                    .HasConstraintName("FK__Store__preset_pi__33D4B598");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
