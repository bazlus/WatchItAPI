namespace WatchIt.MoviesImportingConsole.Extentions
{
    using Autofac;
    public static class ContainerBulderExtentions
    {
        public static void RegisterAppComponents (this ContainerBuilder builder)
        {
            builder.RegisterType<StartUp>();
        } 
    }
}
