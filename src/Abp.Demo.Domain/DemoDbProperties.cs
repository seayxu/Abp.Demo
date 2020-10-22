namespace Abp.Demo
{
    public static class DemoDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Demo";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Demo";
    }
}
