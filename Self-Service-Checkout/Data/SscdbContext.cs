using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Self_Service_Checkout.Models;

namespace Self_Service_Checkout.Data;

public partial class SscdbContext : DbContext
{
    public SscdbContext()
    {
    }

    public SscdbContext(DbContextOptions<SscdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionItem> TransactionItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=SSCDB;Username=postgres;Password=P@ssw0rd");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresEnum("employee_type", new[] { "cashier", "beginner", "admin" })
            .HasPostgresEnum("product_category", new[] { "fruit", "vegetable", "breadstuff", "meat", "drink", "dairy", "sweet", "frozen food", "alcohol", "energy drink" })
            .HasPostgresEnum<Product_Category>("product_category")
            .HasPostgresEnum<EmployeeType>("employee_type");

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("id_customers");

            entity.ToTable("customers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("phone_number");
            entity.Property(e => e.Surname)
                .HasColumnType("character varying")
                .HasColumnName("surname");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("id_employees");

            entity.ToTable("employees");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccessCode).HasColumnName("access_code");
            entity.Property(e => e.employeeType).HasColumnName("employee_type")
                    .HasConversion<string>();
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("phone_number");
            entity.Property(e => e.Surname)
                .HasColumnType("character varying")
                .HasColumnName("surname");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("id_products");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Barcode).HasColumnName("barcode");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductCategory).HasColumnName("product_type")
                    .HasConversion<string>(); 

            entity.Property(e => e.ProductName)
                .HasColumnType("character varying")
                .HasColumnName("product_name");
            entity.Property(e => e.Weight)
                .HasComment("weight in grams")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("id_transactions");

            entity.ToTable("transactions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerFk).HasColumnName("customer_fk");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.EmployeesFk).HasColumnName("employees_fk");
            entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

            entity.HasOne(d => d.CustomerFkNavigation).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.CustomerFk)
                .HasConstraintName("customer_fk");

            entity.HasOne(d => d.EmployeesFkNavigation).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.EmployeesFk)
                .HasConstraintName("employee_fk");
        });

        modelBuilder.Entity<TransactionItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("id_transaction_items");

            entity.ToTable("transaction_items");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.ProductFk).HasColumnName("product_fk");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.TransactionFk).HasColumnName("transaction_fk");

            entity.HasOne(d => d.ProductFkNavigation).WithMany(p => p.TransactionItems)
                .HasForeignKey(d => d.ProductFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("product_fk");

            entity.HasOne(d => d.TransactionFkNavigation).WithMany(p => p.TransactionItems)
                .HasForeignKey(d => d.TransactionFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transaction_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
