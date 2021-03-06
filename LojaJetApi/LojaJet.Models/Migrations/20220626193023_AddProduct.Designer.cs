// <auto-generated />
using LojaJet.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LojaJet.Models.Migrations
{
    [DbContext(typeof(LojaJetContext))]
    [Migration("20220626193023_AddProduct")]
    partial class AddProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LojaJet.Models.Entities.ProductEntity", b =>
                {
                    b.Property<int>("id_product")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ds_product")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("inventory")
                        .HasColumnType("int");

                    b.Property<string>("nm_product")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("price")
                        .HasColumnType("double");

                    b.Property<bool>("status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("id_product");

                    b.ToTable("tb_product");
                });
#pragma warning restore 612, 618
        }
    }
}
