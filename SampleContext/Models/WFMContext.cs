using Microsoft.EntityFrameworkCore;
using SampleTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleContext.Models
{
    public class WFMContext : DbContext
    {
               
        #region Constructor        
        public WFMContext(DbContextOptions options) : base(options)
        { }
        #endregion

        #region Configuration        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); ConfigureModels(modelBuilder);

        }
        #endregion

        #region Models Configuration        
        private static void ConfigureModels(ModelBuilder modelBuilder)
        {
            #region Entity: Skills            
            modelBuilder.Entity<Skills>().ToTable("Skills");
            modelBuilder.Entity<Skills>().Property(x => x.Name).IsRequired().HasMaxLength(30).HasColumnType("varchar");
            #endregion

            #region Entity: Employee            
            modelBuilder.Entity<Employees>().ToTable("Employees");
            modelBuilder.Entity<Employees>().Property(x => x.EmpName).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            modelBuilder.Entity<Employees>().Property(x => x.Status).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            modelBuilder.Entity<Employees>().Property(x => x.Manager).HasMaxLength(30).HasColumnType("varchar");

            modelBuilder.Entity<Employees>().Property(x => x.Wfmanager).HasMaxLength(30).HasColumnType("varchar");
            modelBuilder.Entity<Employees>().Property(x => x.Email).HasColumnType("varchar");
            modelBuilder.Entity<Employees>().Property(x => x.Lockstatus).HasMaxLength(30).HasColumnType("varchar");
            modelBuilder.Entity<Employees>().Property(x => x.Experience).HasColumnType("decimal(5,0)");
            modelBuilder.Entity<Employees>().Property(x => x.ProfileId).HasColumnType("decimal(5,0)");
            #endregion

            #region Entity: User            
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Users>().Property(x => x.Username).IsRequired().HasMaxLength(30).HasColumnType("varchar");
            modelBuilder.Entity<Users>().Property(x => x.Password).IsRequired().HasMaxLength(30).HasColumnType("varchar");
            modelBuilder.Entity<Users>().Property(x => x.Name).IsRequired().HasMaxLength(30).HasColumnType("varchar");
            modelBuilder.Entity<Users>().Property(x => x.Role).IsRequired().HasMaxLength(30).HasColumnType("varchar");
            modelBuilder.Entity<Users>().Property(x => x.Email);
            #endregion

            #region Entity: Softlock           
            modelBuilder.Entity<Softlock>().ToTable("Softlocks");
            modelBuilder.Entity<Softlock>().Property(x => x.Manager).HasMaxLength(30).HasColumnType("varchar");
            modelBuilder.Entity<Softlock>().Property(x => x.Reqdate);
            modelBuilder.Entity<Softlock>().Property(x => x.Status).HasMaxLength(30).HasColumnType("varchar");
            modelBuilder.Entity<Softlock>().Property(x => x.LastUpdated);
            modelBuilder.Entity<Softlock>().Property(x => x.RequestMessage).HasColumnType("varchar");
            modelBuilder.Entity<Softlock>().Property(x => x.WFMRemark).HasColumnType("varchar");
            modelBuilder.Entity<Softlock>().Property(x => x.ManagerStatus).HasMaxLength(30).HasDefaultValue("awaiting_approval").HasColumnType("varchar");
            modelBuilder.Entity<Softlock>().Property(x => x.MGRStatusComments).HasColumnType("varchar");
            modelBuilder.Entity<Softlock>().Property(x => x.MgrLastUpdate);
            modelBuilder.Entity<Softlock>().HasOne(e => e.Employee).WithMany(b => b.softlocks).HasForeignKey(c => c.EmployeeId).OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region Entity: SkillMap            
            modelBuilder.Entity<Skillmap>().ToTable("SkillMaps");
            modelBuilder.Entity<Skillmap>().HasOne(a => a.employee).WithMany(b => b.skillMaps).HasForeignKey(c => c.EmployeeId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Skillmap>().HasOne(a => a.skills).WithMany(b => b.SkillMaps).HasForeignKey(c => c.SkillId).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
        #endregion
    }
}


