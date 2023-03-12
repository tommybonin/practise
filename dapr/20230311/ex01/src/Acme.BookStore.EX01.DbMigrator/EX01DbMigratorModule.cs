using Acme.BookStore.EX01.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.BookStore.EX01.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EX01EntityFrameworkCoreModule),
    typeof(EX01ApplicationContractsModule)
    )]
public class EX01DbMigratorModule : AbpModule
{

}
