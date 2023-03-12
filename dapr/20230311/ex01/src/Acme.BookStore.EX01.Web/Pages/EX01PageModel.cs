using Acme.BookStore.EX01.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.BookStore.EX01.Web.Pages;

public abstract class EX01PageModel : AbpPageModel
{
    protected EX01PageModel()
    {
        LocalizationResourceType = typeof(EX01Resource);
    }
}
