using Acme.BookStore.EX01.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.EX01.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EX01Controller : AbpControllerBase
{
    protected EX01Controller()
    {
        LocalizationResource = typeof(EX01Resource);
    }
}
