using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcMyExampleServer.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CategoryServiceSE1.Models.Category", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<string>("Name")
                    .HasColumnType("text");

                b.Property<int>("ParentCategoryId")
                    .HasColumnType("integer");

                b.HasKey("Id");

                b.HasIndex("ParentCategoryId");

                b.ToTable("Categories");
            });

            modelBuilder.Entity("CategoryServiceSE1.Models.Product", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<int>("CategoryId")
                    .HasColumnType("integer");

                b.Property<string>("Description")
                    .HasColumnType("text");

                b.Property<string>("Name")
                    .HasColumnType("text");

                b.HasKey("Id");

                b.HasIndex("CategoryId");

                b.ToTable("Products");
            });

            modelBuilder.Entity("GrpcMyExampleServer.Models.Category", b =>
            {
                b.HasOne("GrpcMyExampleServer.Models.Category", "ParentCategory")
                    .WithMany()
                    .HasForeignKey("ParentCategoryId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("CategoryServiceSE1.Models.Product", b =>
            {
                b.HasOne("CategoryServiceSE1.Models.Category", "Category")
                    .WithMany()
                    .HasForeignKey("CategoryId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}
