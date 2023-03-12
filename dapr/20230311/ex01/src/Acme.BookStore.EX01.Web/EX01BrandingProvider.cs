using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore.EX01.Web;

[Dependency(ReplaceServices = true)]
public class EX01BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EX01";
}
