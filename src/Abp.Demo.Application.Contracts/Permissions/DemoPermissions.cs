using Volo.Abp.Reflection;

namespace Abp.Demo.Permissions
{
    public class DemoPermissions
    {
        public const string GroupName = "Demo";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(DemoPermissions));
        }
    }
}