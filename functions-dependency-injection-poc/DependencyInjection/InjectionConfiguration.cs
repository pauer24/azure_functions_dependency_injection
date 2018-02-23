using functions_dependency_injection_poc.Services;
using Microsoft.Azure.WebJobs.Host.Config;
using Microsoft.Extensions.DependencyInjection;

namespace functions_dependency_injection_poc.DependencyInjection
{
    public class InjectConfiguration : IExtensionConfigProvider
    {
        public void Initialize(ExtensionConfigContext context)
        {
            var services = new ServiceCollection();
            RegisterServices(services);
            var serviceProvider = services.BuildServiceProvider(true);

            context
                .AddBindingRule<InjectAttribute>()
                .Bind(new InjectBindingProvider(serviceProvider));
        }

        private void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ITestService, TestService>();
        }
    }
}