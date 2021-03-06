// <auto-generated />
using DL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DL.Migrations
{
    [DbContext(typeof(RecipeBookDBContext))]
    partial class RecipeBookDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Models.AppUser", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Models.Ingredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Measurement")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Quantity")
                        .HasColumnType("double precision");

                    b.Property<int>("RecipeID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Models.Recipe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("CalorieCount")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Origin")
                        .HasColumnType("text");

                    b.Property<int>("Servings")
                        .HasColumnType("integer");

                    b.Property<bool>("Vegan")
                        .HasColumnType("boolean");

                    b.Property<bool>("Vegetarian")
                        .HasColumnType("boolean");
                    b.Property<int>("AuthorID")
                        .HasColumnType("integer");
                    b.HasKey("ID");

                    b.ToTable("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
