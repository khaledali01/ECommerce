using ECommerce.Data.Entities;
using ECommerce.Data.UserModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public class ECommerceContext : IdentityDbContext<ApplicationUser>
    {
		public ECommerceContext()
		{
		}

		public IConfiguration _configuration { get; }
        public ECommerceContext(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

		

		public DbSet<Product> Products { get; set; }

		public DbSet<ApplicationUser> AspNetUsers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection string

            optionsBuilder
                .UseSqlServer(_configuration
                    .GetConnectionString("connectionStr"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            


			modelBuilder.Entity<Product>()
                .HasData(
                  new Product()
                  {
                      ProductID = 1,
                      Name = "MMO Mug",
                      Description = "Legendary Coffee Mug Level 110 - Large Ceramic Black Coffee Mug 15oz - Gaming, Gamer Cup.",
                      Price = 31,
                      Quantity = 1,
                      Color = "Black",
                      Brand = "Funny Mugs, LOL",
                      ImageURL = "/images/MMO Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 2,
                      Name = "Bubble Hugs Mug",
                      Description = "Gaming Progress - Video Game Funny Humor Sarcasm Saying 15oz Black.",
                      Price = 22,
                      Quantity = 1,
                      Color = "Black",
                      Brand = "Bubble Hugs",
                      ImageURL = "/images/Bubble Hugs Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 3,
                      Name = "HEYTEE Mug",
                      Description = "LHEYTEE Funny Coffee Mugs for Dad Coffee Mug, 11oz Ceramic Dad Coffee Cup_009.",
                      Price = 27,
                      Quantity = 1,
                      Color = "White",
                      Brand = "HEYTEE",
                      ImageURL = "/images/HEYTEE Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 4,
                      Name = "LiqCool Mug",
                      Description = "Sometimes You Forget Youre Awesome Coffee Mug, Thank You Gifts, Gifts for Coworkers, Birthday Christmas Appreciation Gift for Employee Women Men (12 oz, Purple).",
                      Price = 35,
                      Quantity = 1,
                      Color = "Purple",
                      Brand = "LiqCool",
                      ImageURL = "/images/LiqCool Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 5,
                      Name = "Sodilly Mug",
                      Description = "Gaming Mugs for Men - Gamer Gifts for Men - Gifts for Gamer Boyfriend - Boys Gaming Room Decor - Gamer Cup Insulated Stainless Steel 16 oz Black Funny Tumbler for Men.",
                      Price = 23,
                      Quantity = 1,
                      Color = "Black",
                      Brand = "Sodilly",
                      ImageURL = "/images/Sodilly Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 6,
                      Name = "Onebttl Mug",
                      Description = "Gaming Mugs , Boys, Teen, 20oz Stainless Steel Tumbler, Gifts For Christmas, Birthday- I'd Rather Be Gaming.",
                      Price = 31,
                      Quantity = 1,
                      Color = "Black/Green",
                      Brand = "Onebttl",
                      ImageURL = "/images/Onebttl Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 7,
                      Name = "ECKOI Mug",
                      Description = "Unique Black Mesa Research Facility Mug Gamer Gift Geek Gift Gaming Gift Half Life Portal Valve Birthday Gift For my mother funny humor cup gift coffee tea ceramic cup friends men 11oz.",
                      Price = 42,
                      Quantity = 1,
                      Color = "Black Mesa",
                      Brand = "ECKOI",
                      ImageURL = "/images/ECKOI Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 8,
                      Name = "3dRose Mug",
                      Description = "computer pro-gamer in black and purple Mug, 1 Count (Pack of 1).",
                      Price = 22,
                      Quantity = 1,
                      Color = "White/Black",
                      Brand = "3dRose",
                      ImageURL = "/images/3dRose Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 9,
                      Name = "KrysDesigns Mug",
                      Description = "Can't Hear You I'm Gaming Mug - Gamer Coffee Mug - Video Game Player Gaming Mug - Coffee Mug 11oz, White.",
                      Price = 45,
                      Quantity = 1,
                      Color = "White",
                      Brand = "KrysDesigns",
                      ImageURL = "/images/KrysDesigns Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 10,
                      Name = "Vsitoo Mug",
                      Description = "S3 Temperature Control Smart Mug 2 with Lid, Self Heating Coffee Mug 10 oz, LED Display, 90 Min Battery Life - App&Manual Controlled Heated Coffee Mug - Improved Design - Perfect Coffee Gifts.",
                      Price = 31,
                      Quantity = 1,
                      Color = "Black",
                      Brand = "Vsitoo",
                      ImageURL = "/images/Vsitoo Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 11,
                      Name = "Paladone Mug",
                      Description = "Playstation 5 Heat Change Mug -Officially Licensed Merchandise.",
                      Price = 37,
                      Quantity = 1,
                      Color = "Black/White",
                      Brand = "Paladone",
                      ImageURL = "/images/Paladone Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 12,
                      Name = "Nofinis Mug",
                      Description = "Heat Changing Sensitive Mug - Cool Coffee & Tea Magic Color Change Cup Battery Meter Charging Design Ceramic Mug Gift Idea for Mom Dad Women & Men.",
                      Price = 41,
                      Quantity = 1,
                      Color = "Black",
                      Brand = "Nofinis",
                      ImageURL = "/images/Nofinis Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 13,
                      Name = "YHRJWN Mug",
                      Description = "Gifts for Women, Thank You Awesome Mug, Coworkers Leaving Gifts for Women, Thank You Gifts for Friends Employee Assistant, Administrative Professional Day Christmas Gifts with Keychain 11 Oz.",
                      Price = 31,
                      Quantity = 1,
                      Color = "White/Pink",
                      Brand = "YHRJWN",
                      ImageURL = "/images/YHRJWN Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 14,
                      Name = "MUGNIV Mug",
                      Description = "Game Over Controller Novelty Mug: Ceramic Coffee Mugs & Tea Cup , Unique & Fun Cool Mug for Gamers, Coffee Lovers Gifts, Video Game Decor Kitchen Cups - 12.4 Oz.",
                      Price = 36,
                      Quantity = 1,
                      Color = "White",
                      Brand = "MUGNIV",
                      ImageURL = "/images/MUGNIV Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 15,
                      Name = "HOOMUU Mug",
                      Description = "Gaming Coffee Mug Gift- Tears Of My Enemies - Funny Ceramic Coffee Mugs for Boyfriend Men Sisters - Novetly Wine Glasses for Fathers Day Birthday Valentines Gifts.",
                      Price = 29,
                      Quantity = 1,
                      Color = "White",
                      Brand = "HOOMUU",
                      ImageURL = "/images/HOOMUU Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 16,
                      Name = "Ember Mug",
                      Description = "Temperature Control Smart Mug 2, 10 Oz, App-Controlled Heated Coffee Mug with 80 Min Battery Life and Improved Design, Rose Gold.",
                      Price = 33,
                      Quantity = 1,
                      Color = "Rose Gold",
                      Brand = "Ember",
                      ImageURL = "/images/Ember Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 17,
                      Name = "Wampumtuk Mug",
                      Description = "Addicted to Pot 11 Ounces Funny Coffee Mug.",
                      Price = 46,
                      Quantity = 1,
                      Color = "White",
                      Brand = "Wampumtuk",
                      ImageURL = "/images/Wampumtuk Mug.jpg"

                  }, new Product()
                  {
                      ProductID = 18,
                      Name = "KTOTKMOTA Mug",
                      Description = "Nordic Viking Rune Mug Tankard Stainless Steel Wooden Resin 3D Norse Decor Coffee Cool Gothic Beer Tankard Stein Cup Mugs 20oz.",
                      Price = 56,
                      Quantity = 1,
                      Color = "Dark Grey",
                      Brand = "KTOTKMOTA",
                      ImageURL = "/images/KTOTKMOTA Mug.jpg"

                  }
                 );

			base.OnModelCreating(modelBuilder);
			modelBuilder.Ignore<IdentityRole>();
			modelBuilder.Ignore<IdentityUserToken<string>>();
			modelBuilder.Ignore<IdentityUserRole<string>>();
			modelBuilder.Ignore<IdentityUserLogin<string>>();
			modelBuilder.Ignore<IdentityUserClaim<string>>();
			modelBuilder.Ignore<IdentityRoleClaim<string>>();
            modelBuilder.Entity<ApplicationUser>();

			modelBuilder.Entity<ApplicationUser>()
				.Ignore(c => c.AccessFailedCount)
				.Ignore(c => c.LockoutEnabled)
				.Ignore(c => c.TwoFactorEnabled)
				.Ignore(c => c.ConcurrencyStamp)
				.Ignore(c => c.LockoutEnd)
				.Ignore(c => c.EmailConfirmed)
				.Ignore(c => c.TwoFactorEnabled)
				.Ignore(c => c.LockoutEnd)
				.Ignore(c => c.AccessFailedCount)
				.Ignore(c => c.PhoneNumberConfirmed);




		}

    }
}