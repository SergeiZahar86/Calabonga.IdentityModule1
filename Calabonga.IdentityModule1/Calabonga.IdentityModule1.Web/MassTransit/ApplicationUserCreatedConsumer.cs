using Calabonga.Contracts;
using MassTransit;
using System.Threading.Tasks;

namespace Calabonga.IdentityModule1.Web.MassTransit
{
    public class ApplicationUserCreatedConsumer : IConsumer<IApplicationUserCreated>
    {
        public Task Consume(ConsumeContext<IApplicationUserCreated> context)
        {
            return Task.CompletedTask;
        }
    }
}
