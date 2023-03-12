using Acme.BookStore.EX01.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.EX01.Permissions;

public class EX01PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EX01Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EX01Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EX01Resource>(name);
    }
}
