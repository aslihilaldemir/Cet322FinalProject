using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cet322FinalProject.Models;

namespace Cet322FinalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        public DbSet<Cet322FinalProject.Models.Category> Categories { get; set; }

        public DbSet<Cet322FinalProject.Models.Comment> Comments { get; set; }

        public DbSet<Cet322FinalProject.Models.Gallery> Galleries { get; set; }

        public DbSet<Cet322FinalProject.Models.Post> Posts { get; set; }

        public DbSet<Cet322FinalProject.Models.Poll> Polls { get; set; }

        public DbSet<Cet322FinalProject.Models.PostImage> PostImages { get; set; }

        public DbSet<Cet322FinalProject.Models.GalleryImage> GalleryImages { get; set; }


    }
}