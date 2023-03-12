using System.Threading.Tasks;

namespace Acme.BookStore.EX01.Data;

public interface IEX01DbSchemaMigrator
{
    Task MigrateAsync();
}
