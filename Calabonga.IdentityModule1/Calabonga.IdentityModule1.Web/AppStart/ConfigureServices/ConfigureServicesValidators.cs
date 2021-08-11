using Calabonga.IdentityModule1.Web.ViewModels.AccountViewModels;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Calabonga.IdentityModule1.Web.AppStart.ConfigureServices
{
    /// <summary>
    /// ASP.NET Core services registration and configurations
    /// </summary>
    public static class ConfigureServicesValidators
    {
        /// <summary>
        /// ConfigureServices Services
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(typeof(Startup).Assembly);
        }
    }
}