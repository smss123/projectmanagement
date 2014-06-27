using System;
using System.Data.Entity;
using ProjectManagment.DataLayer.Accountant;
using ProjectManagment.DataLayer.Managment;
using ProjectManagment.DataLayer.Employee;
using ProjectManagment.DataLayer.Expenses;
using ProjectManagment.DataLayer.Order;
using ProjectManagment.DataLayer.Suppler;
namespace ProjectManagment.DataLayer
{
    public class dbContext : DbContext, IDisposable
    {
        public DbSet<UserGroups> userGroups { get; set; }
        public DbSet<SystemUser> systemUsers { get; set; }
        public DbSet<GroupPermession> groupPersessions { get; set; }

#region"Account region"
        public DbSet<Account> accounts { get; set; }
        public DbSet<DailyMovemnt> dailymovemnts { get; set; }
        public DbSet<Transaction> transactions { get; set; }
#endregion

 #region"Manganment region"
        public DbSet<ProjectProfile> projectProfiles { get; set; }
        public DbSet<ProjectActivity> projectActivities { get; set; }
        public DbSet<ProjectSubActivity> projectSubActivities { get; set; }


 #endregion

 #region"Employee region"
        public DbSet<Contracts> emplyee { get; set; }
        public DbSet<Employee.Employee> person { get; set; }
        public DbSet<SelaryHiracy> selaryHiracy { get; set; }

 #endregion

 #region"Expenses region"
        public DbSet<ProjectExpenses> projectExpenses { get; set; }

#endregion
#region"Order region"
        public DbSet<Attachment> attachment { get; set; }
        public DbSet<ProjectOrder> projectOrder { get; set; }
#endregion

#region"Suppler region"
        public DbSet<Suppliers> suppliers { get; set; }

#endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserGroups>().MapToStoredProcedures();
            modelBuilder.Entity<SystemUser>().MapToStoredProcedures();
            modelBuilder.Entity<GroupPermession>().MapToStoredProcedures();
            modelBuilder.Entity<Account>().MapToStoredProcedures();
            modelBuilder.Entity<DailyMovemnt>().MapToStoredProcedures();
            modelBuilder.Entity<Transaction>().MapToStoredProcedures();
            modelBuilder.Entity<ProjectProfile>().MapToStoredProcedures();
            modelBuilder.Entity<ProjectActivity>().MapToStoredProcedures();
            modelBuilder.Entity<ProjectSubActivity>().MapToStoredProcedures();
            modelBuilder.Entity<Contracts>().MapToStoredProcedures();
            modelBuilder.Entity<Employee.Employee>().MapToStoredProcedures();
            modelBuilder.Entity<SelaryHiracy>().MapToStoredProcedures();
            modelBuilder.Entity<ProjectExpenses>().MapToStoredProcedures();
            modelBuilder.Entity<Attachment>().MapToStoredProcedures();
            modelBuilder.Entity<ProjectOrder>().MapToStoredProcedures();
            modelBuilder.Entity<Suppliers>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }


         void IDisposable.Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }
    }
}
