using Volo.Abp.Settings;

namespace Acme.BookStore.EX01.Settings;

public class EX01SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EX01Settings.MySetting1));
    }
}
