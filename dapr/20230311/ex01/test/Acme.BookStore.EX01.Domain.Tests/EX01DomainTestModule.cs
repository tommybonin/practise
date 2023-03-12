using Acme.BookStore.EX01.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.BookStore.EX01;

[DependsOn(
    typeof(EX01EntityFrameworkCoreTestModule)
    )]
public class EX01DomainTestModule : AbpModule
{

}
