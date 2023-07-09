using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
namespace SpitalFinal.Models
{
    public class SpitalContext : IdentityDbContext<IdentityUser>
    {

        public SpitalContext(DbContextOptions<SpitalContext> options)
        : base(options) { }
        public DbSet<Medic> Medics { get; set; }
        public DbSet<RetetaMedicala> RetetaMedicals { get; set; }
        public DbSet<Sectie> Secties { get; set; }
        public DbSet<Investigatie> Investigaties { get; set; }
        public DbSet<FisaMedic> FisaMedics { get; set; }
        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<Programare> Programares { get; set; }
        public DbSet<ProgramLucru> ProgramLucrus { get; set; }

        public DbSet<IdentityUser> IdentityUsers { get; set; }
        public DbSet<IdentityRole> IdentityRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Cetatean>()
            //    .HasOne(p => p.Rol)
            //    .WithMany(s => s.Users) // Specify the navigation property in Supplier entity
            //    .HasForeignKey(p => p.RolId);


            //modelBuilder.Entity<Product>()
            //   .HasOne(p => p.Supplier)
            //   .WithMany(s => s.Products) // Specify the navigation property in Supplier entity
            //   .HasForeignKey(p => p.SupplierId);

            //modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(l => new { l.LoginProvider, l.ProviderKey });
            //modelBuilder.Entity<IdentityUserRole<string>>().HasKey(r => new { r.UserId, r.RoleId });
           // modelBuilder.Entity<Sectie>()
           // .HasMany(s => s.Medics)
           // .WithOne(m => m.Sectie)
           // .HasForeignKey(m => m.SectieId)
           //.OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Medic>()
                .HasOne(sp => sp.Sectie)
                .WithMany(s => s.Medics)
                .HasForeignKey(sp => sp.SectieId)
                .OnDelete(DeleteBehavior.Cascade);
      
  

            modelBuilder.Entity<Programare>()
                 .HasOne(sp => sp.Medic)
                 .WithMany(S => S.Programares)
                 .HasForeignKey(sc => sc.MedicId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Programare>()
                .HasOne(sc => sc.ProgramLucru)
                .WithMany(s => s.Programares)
                .HasForeignKey(sc => sc.ProgramLucruId);

            modelBuilder.Entity<FisaMedic>()
                .HasOne(sc => sc.Medic)
                .WithMany(s => s.FisaMedics)
                .HasForeignKey(sc => sc.MedicId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FisaMedic>()
                .HasOne(sc => sc.Pacient)
                .WithMany(s => s.FisaMedics)
                .HasForeignKey(sc => sc.PacientId);

            modelBuilder.Entity<FisaMedic>()
               .HasOne(sc => sc.RetetaMedicala)
               .WithMany(s => s.FisaMedics)
               .HasForeignKey(sc => sc.RetetaMedicalaId);


            modelBuilder.Entity<Investigatie>()
               .HasOne(sc => sc.FisaMedic)
               .WithMany(s => s.Investigaties)
               .HasForeignKey(sc => sc.FisaMedicId)
               .OnDelete(DeleteBehavior.Cascade);


            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Ignore<IdentityUserLogin<string>>();


            //modelBuilder.Entity<IdentityUserLogin<string>>()
            //  .HasKey(l => new { l.LoginProvider, l.ProviderKey });

            //// Alte configurări ale modelului
            ///        public bool ObiecteAsociate


            base.OnModelCreating(modelBuilder);




        }
    }
}
