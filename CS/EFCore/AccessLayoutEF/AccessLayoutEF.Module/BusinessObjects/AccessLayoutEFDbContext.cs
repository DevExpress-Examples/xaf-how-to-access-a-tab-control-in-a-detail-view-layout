using DevExpress.ExpressApp.EFCore.Updating;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.DesignTime;

namespace AccessLayoutEF.Module.BusinessObjects;

// This code allows our Model Editor to get relevant EF Core metadata at design time.
// For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
public class AccessLayoutEFContextInitializer : DbContextTypesInfoInitializerBase {
	protected override DbContext CreateDbContext() {
		var optionsBuilder = new DbContextOptionsBuilder<AccessLayoutEFEFCoreDbContext>()
            .UseSqlServer(";")
            .UseChangeTrackingProxies()
            .UseObjectSpaceLinkProxies();
        return new AccessLayoutEFEFCoreDbContext(optionsBuilder.Options);
	}
}
//This factory creates DbContext for design-time services. For example, it is required for database migration.
public class AccessLayoutEFDesignTimeDbContextFactory : IDesignTimeDbContextFactory<AccessLayoutEFEFCoreDbContext> {
	public AccessLayoutEFEFCoreDbContext CreateDbContext(string[] args) {
		throw new InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.");
		//var optionsBuilder = new DbContextOptionsBuilder<AccessLayoutEFEFCoreDbContext>();
		//optionsBuilder.UseSqlServer("Integrated Security=SSPI;Pooling=false;Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AccessLayoutEF");
        //optionsBuilder.UseChangeTrackingProxies();
        //optionsBuilder.UseObjectSpaceLinkProxies();
		//return new AccessLayoutEFEFCoreDbContext(optionsBuilder.Options);
	}
}
[TypesInfoInitializer(typeof(AccessLayoutEFContextInitializer))]
public class AccessLayoutEFEFCoreDbContext : DbContext {
	public AccessLayoutEFEFCoreDbContext(DbContextOptions<AccessLayoutEFEFCoreDbContext> options) : base(options) {
	}
    //public DbSet<ModuleInfo> ModulesInfo { get; set; }
    public DbSet<MyTask> MyTasks { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
    }
}
