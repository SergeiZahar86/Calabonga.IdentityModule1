using Calabonga.Contracts;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabonga.IdentityModule1.Web.MassTransit
{
    public class ApplicationUserProfilerResponseConsumer
       : IConsumer<IApplicationUserProfileResponse>
    {
        public async Task Consume(ConsumeContext<IApplicationUserProfileResponse> context)
        {
            var request = context.Message;
            var data = new ApplicationUserProfileResponse
            {
                PetName = "Pussy",
                FavoriteColor = "Magenta",
                Skills = "NET, Core, Blazor, MVC, Silverlight",
                Id = request.Id
            };
            await context.RespondAsync(data);


        }
    }
}
