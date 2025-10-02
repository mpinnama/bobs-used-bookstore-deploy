using Bookstore.Domain.Addresses;
using Bookstore.Domain.Books;
using Bookstore.Domain.Carts;
using Bookstore.Domain.Customers;
using Bookstore.Domain.Offers;
using Bookstore.Domain.Orders;
using Bookstore.Domain.ReferenceData;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Address> Address { get; set; }

        public DbSet<Book> Book { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<ShoppingCart> ShoppingCart { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }

        public DbSet<OrderItem> OrderItem { get; set; }

        public DbSet<Offer> Offer { get; set; }

        public DbSet<ReferenceDataItem> ReferenceData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set default schema
            modelBuilder.HasDefaultSchema("bobsusedbookstore_dbo");

            // Configure entity table mappings
            modelBuilder.Entity<Address>().ToTable("address");
            modelBuilder.Entity<Book>().ToTable("book");
            modelBuilder.Entity<Customer>().ToTable("customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<ShoppingCart>().ToTable("shoppingcart");
            modelBuilder.Entity<ShoppingCartItem>().ToTable("shoppingcartitem");
            modelBuilder.Entity<OrderItem>().ToTable("orderitem");
            modelBuilder.Entity<Offer>().ToTable("offer");
            modelBuilder.Entity<ReferenceDataItem>().ToTable("referencedata");

            // Configure Address entity column mappings
            modelBuilder.Entity<Address>().Property(p => p.AddressLine1).HasColumnName("addressline1");
            modelBuilder.Entity<Address>().Property(p => p.AddressLine2).HasColumnName("addressline2");
            modelBuilder.Entity<Address>().Property(p => p.City).HasColumnName("city");
            modelBuilder.Entity<Address>().Property(p => p.State).HasColumnName("state");
            modelBuilder.Entity<Address>().Property(p => p.Country).HasColumnName("country");
            modelBuilder.Entity<Address>().Property(p => p.ZipCode).HasColumnName("zipcode");
            modelBuilder.Entity<Address>().Property(p => p.CustomerId).HasColumnName("customerid");
            modelBuilder.Entity<Address>().Property(p => p.IsActive).HasColumnName("isactive");
            modelBuilder.Entity<Address>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<Address>().Property(p => p.CreatedBy).HasColumnName("createdby");
            modelBuilder.Entity<Address>().Property(p => p.RowVersion).HasColumnName("rowversion");

            // Configure Book entity column mappings
            modelBuilder.Entity<Book>().Property(p => p.Name).HasColumnName("name");
            modelBuilder.Entity<Book>().Property(p => p.Author).HasColumnName("author");
            modelBuilder.Entity<Book>().Property(p => p.Year).HasColumnName("year");
            modelBuilder.Entity<Book>().Property(p => p.ISBN).HasColumnName("isbn");
            modelBuilder.Entity<Book>().Property(p => p.PublisherId).HasColumnName("publisherid");
            modelBuilder.Entity<Book>().Property(p => p.BookTypeId).HasColumnName("booktypeid");
            modelBuilder.Entity<Book>().Property(p => p.GenreId).HasColumnName("genreid");
            modelBuilder.Entity<Book>().Property(p => p.ConditionId).HasColumnName("conditionid");
            modelBuilder.Entity<Book>().Property(p => p.CoverImageUrl).HasColumnName("coverimageurl");
            modelBuilder.Entity<Book>().Property(p => p.Summary).HasColumnName("summary");
            modelBuilder.Entity<Book>().Property(p => p.Price).HasColumnName("price");
            modelBuilder.Entity<Book>().Property(p => p.Quantity).HasColumnName("quantity");
            modelBuilder.Entity<Book>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<Book>().Property(p => p.CreatedBy).HasColumnName("createdby");
            modelBuilder.Entity<Book>().Property(p => p.RowVersion).HasColumnName("rowversion");

            // Configure Customer entity column mappings
            modelBuilder.Entity<Customer>().Property(p => p.Sub).HasColumnName("sub");
            modelBuilder.Entity<Customer>().Property(p => p.Username).HasColumnName("username");
            modelBuilder.Entity<Customer>().Property(p => p.FirstName).HasColumnName("firstname");
            modelBuilder.Entity<Customer>().Property(p => p.LastName).HasColumnName("lastname");
            modelBuilder.Entity<Customer>().Property(p => p.Email).HasColumnName("email");
            modelBuilder.Entity<Customer>().Property(p => p.Phone).HasColumnName("phone");
            modelBuilder.Entity<Customer>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<Customer>().Property(p => p.CreatedBy).HasColumnName("createdby");
            modelBuilder.Entity<Customer>().Property(p => p.RowVersion).HasColumnName("rowversion");

            // Configure Order entity column mappings
            modelBuilder.Entity<Order>().Property(p => p.CustomerId).HasColumnName("customerid");
            modelBuilder.Entity<Order>().Property(p => p.AddressId).HasColumnName("addressid");
            modelBuilder.Entity<Order>().Property(p => p.Tax).HasColumnName("tax");
            modelBuilder.Entity<Order>().Property(p => p.SubTotal).HasColumnName("subtotal");
            modelBuilder.Entity<Order>().Property(p => p.Total).HasColumnName("total");
            modelBuilder.Entity<Order>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<Order>().Property(p => p.CreatedBy).HasColumnName("createdby");
            modelBuilder.Entity<Order>().Property(p => p.RowVersion).HasColumnName("rowversion");

            // Configure ShoppingCart entity column mappings
            modelBuilder.Entity<ShoppingCart>().Property(p => p.CorrelationId).HasColumnName("correlationid");
            modelBuilder.Entity<ShoppingCart>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<ShoppingCart>().Property(p => p.CreatedBy).HasColumnName("createdby");
            modelBuilder.Entity<ShoppingCart>().Property(p => p.RowVersion).HasColumnName("rowversion");

            // Configure ShoppingCartItem entity column mappings
            modelBuilder.Entity<ShoppingCartItem>().Property(p => p.ShoppingCartId).HasColumnName("shoppingcartid");
            modelBuilder.Entity<ShoppingCartItem>().Property(p => p.BookId).HasColumnName("bookid");
            modelBuilder.Entity<ShoppingCartItem>().Property(p => p.Quantity).HasColumnName("quantity");
            modelBuilder.Entity<ShoppingCartItem>().Property(p => p.WantToBuy).HasColumnName("wanttobuy");
            modelBuilder.Entity<ShoppingCartItem>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<ShoppingCartItem>().Property(p => p.CreatedBy).HasColumnName("createdby");
            modelBuilder.Entity<ShoppingCartItem>().Property(p => p.RowVersion).HasColumnName("rowversion");

            // Configure OrderItem entity column mappings
            modelBuilder.Entity<OrderItem>().Property(p => p.OrderId).HasColumnName("orderid");
            modelBuilder.Entity<OrderItem>().Property(p => p.BookId).HasColumnName("bookid");
            modelBuilder.Entity<OrderItem>().Property(p => p.Quantity).HasColumnName("quantity");
            modelBuilder.Entity<OrderItem>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<OrderItem>().Property(p => p.CreatedBy).HasColumnName("createdby");
            modelBuilder.Entity<OrderItem>().Property(p => p.RowVersion).HasColumnName("rowversion");

            // Configure Offer entity column mappings
            modelBuilder.Entity<Offer>().Property(p => p.Author).HasColumnName("author");
            modelBuilder.Entity<Offer>().Property(p => p.ISBN).HasColumnName("isbn");
            modelBuilder.Entity<Offer>().Property(p => p.BookName).HasColumnName("bookname");
            modelBuilder.Entity<Offer>().Property(p => p.FrontUrl).HasColumnName("fronturl");
            modelBuilder.Entity<Offer>().Property(p => p.GenreId).HasColumnName("genreid");
            modelBuilder.Entity<Offer>().Property(p => p.ConditionId).HasColumnName("conditionid");
            modelBuilder.Entity<Offer>().Property(p => p.PublisherId).HasColumnName("publisherid");
            modelBuilder.Entity<Offer>().Property(p => p.BookTypeId).HasColumnName("booktypeid");
            modelBuilder.Entity<Offer>().Property(p => p.Summary).HasColumnName("summary");
            modelBuilder.Entity<Offer>().Property(p => p.Comment).HasColumnName("comment");
            modelBuilder.Entity<Offer>().Property(p => p.CustomerId).HasColumnName("customerid");
            modelBuilder.Entity<Offer>().Property(p => p.BookPrice).HasColumnName("bookprice");
            modelBuilder.Entity<Offer>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<Offer>().Property(p => p.CreatedBy).HasColumnName("createdby");
            modelBuilder.Entity<Offer>().Property(p => p.RowVersion).HasColumnName("rowversion");

            // Configure ReferenceDataItem entity column mappings
            modelBuilder.Entity<ReferenceDataItem>().Property(p => p.Text).HasColumnName("text");
            modelBuilder.Entity<ReferenceDataItem>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<ReferenceDataItem>().Property(p => p.CreatedBy).HasColumnName("createdby");
            modelBuilder.Entity<ReferenceDataItem>().Property(p => p.RowVersion).HasColumnName("rowversion");

            // Original relationship configurations
            modelBuilder.Entity<Customer>().HasIndex(x => x.Sub).IsUnique();

            modelBuilder.Entity<Book>().HasOne(x => x.Publisher).WithMany().HasForeignKey(x => x.PublisherId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Book>().HasOne(x => x.BookType).WithMany().HasForeignKey(x => x.BookTypeId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Book>().HasOne(x => x.Genre).WithMany().HasForeignKey(x => x.GenreId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Book>().HasOne(x => x.Condition).WithMany().HasForeignKey(x => x.ConditionId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Offer>().HasOne(x => x.Publisher).WithMany().HasForeignKey(x => x.PublisherId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Offer>().HasOne(x => x.BookType).WithMany().HasForeignKey(x => x.BookTypeId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Offer>().HasOne(x => x.Genre).WithMany().HasForeignKey(x => x.GenreId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Offer>().HasOne(x => x.Condition).WithMany().HasForeignKey(x => x.ConditionId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>().HasOne(x => x.Customer).WithMany().OnDelete(DeleteBehavior.Restrict);

            PopulateDatabase(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}