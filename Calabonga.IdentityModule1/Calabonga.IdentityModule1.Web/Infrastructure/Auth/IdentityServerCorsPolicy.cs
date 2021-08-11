using IdentityServer4.Services;
using System.Threading.Tasks;

namespace Calabonga.IdentityModule1.Web.Infrastructure.Auth
{
    /// <summary>
    /// Customized CORS policy for IdentityServer4
    /// </summary>
    public class IdentityServerCorsPolicy : ICorsPolicyService
    {
        /// <inheritdoc />
        public Task<bool> IsOriginAllowedAsync(string origin)
        {
            return Task.FromResult(true);
        }

    }
}
