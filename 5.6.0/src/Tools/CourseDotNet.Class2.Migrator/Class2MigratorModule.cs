using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using CourseDotNet.Class2.EntityFramework;

namespace CourseDotNet.Class2.Migrator
{
    [DependsOn(typeof(Class2DataModule))]
    public class Class2MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<Class2DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}