namespace WatchIt.MoviesImportingConsole
{
    using Autofac;
    using WatchIt.MoviesImportingConsole.Extentions;

    class Program
    {
        private static IContainer Container;

        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterAppComponents();
            Container = containerBuilder.Build();

            using var scope = Container.BeginLifetimeScope();
            var startUp = scope.Resolve<StartUp>();
            startUp.Run();
        }
    }
}
