using Volo.Abp.Modularity;

namespace Acme.BookStore.EX01;

[DependsOn(
    typeof(EX01ApplicationModule),
    typeof(EX01DomainTestModule)
    )]
public class EX01ApplicationTestModule : AbpModule
{

}
