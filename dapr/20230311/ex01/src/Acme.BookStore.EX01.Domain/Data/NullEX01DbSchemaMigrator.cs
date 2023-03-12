using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore.EX01.Data;

/* This is used if database provider does't define
 * IEX01DbSchemaMigrator implementation.
 */
public class NullEX01DbSchemaMigrator : IEX01DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
