using Abp.Demo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Demo.Permissions
{
    public class DemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DemoPermissions.GroupName, L("Permission:Demo"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DemoResource>(name);
        }
    }
}