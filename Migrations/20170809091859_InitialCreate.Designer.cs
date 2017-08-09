using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MVC486.Database;

namespace MVC486.Migrations
{
    [DbContext(typeof(ConferenceContext))]
    [Migration("20170809091859_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC486.Models.Session", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abstract")
                        .IsRequired();

                    b.Property<int>("SpeakerID");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("SessionId");

                    b.HasIndex("SpeakerID");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("MVC486.Models.Speaker", b =>
                {
                    b.Property<int>("SpeakerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("SpeakerID");

                    b.ToTable("Speaker");
                });

            modelBuilder.Entity("MVC486.Models.Session", b =>
                {
                    b.HasOne("MVC486.Models.Speaker", "Speaker")
                        .WithMany()
                        .HasForeignKey("SpeakerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
