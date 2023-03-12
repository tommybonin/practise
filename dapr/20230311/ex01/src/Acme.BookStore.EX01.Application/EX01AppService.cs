using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookStore.EX01.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.EX01;

/* Inherit your application services from this class.
 */
public abstract class EX01AppService : ApplicationService
{
    protected EX01AppService()
    {
        LocalizationResource = typeof(EX01Resource);
    }
}
