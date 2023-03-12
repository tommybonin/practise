using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.BookStore.EX01.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore.EX01.EntityFrameworkCore;

public class EntityFrameworkCoreEX01DbSchemaMigrator
    : IEX01DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEX01DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the EX01DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EX01DbContext>()
            .Database
            .MigrateAsync();
    }
}
