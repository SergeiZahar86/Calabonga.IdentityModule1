using Calabonga.IdentityModule1.Data;
using Calabonga.IdentityModule1.Web.Infrastructure.Mappers.Base;
using Calabonga.IdentityModule1.Web.ViewModels.AccountViewModels;

namespace Calabonga.IdentityModule1.Web.Infrastructure.Mappers
{
    /// <summary>
    /// Mapper Configuration for entity Person
    /// </summary>
    public class ApplicationUserProfileMapperConfiguration : MapperConfigurationBase
    {
        /// <inheritdoc />
        public ApplicationUserProfileMapperConfiguration()
        {
            CreateMap<RegisterViewModel, ApplicationUserProfile>()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}