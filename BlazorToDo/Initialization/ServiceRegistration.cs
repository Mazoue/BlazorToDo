namespace BlazorToDo.Initialization
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterCoreServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddRazorPages();
            serviceCollection.AddServerSideBlazor();

            return serviceCollection;
        }
    }
}