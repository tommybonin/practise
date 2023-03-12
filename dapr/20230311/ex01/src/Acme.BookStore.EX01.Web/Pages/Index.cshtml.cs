using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Acme.BookStore.EX01.Web.Pages;

public class IndexModel : EX01PageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
