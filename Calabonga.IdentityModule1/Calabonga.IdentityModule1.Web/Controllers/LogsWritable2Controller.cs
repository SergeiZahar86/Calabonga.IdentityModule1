using AutoMapper;
using Calabonga.IdentityModule1.Data;
using Calabonga.IdentityModule1.Entities;
using Calabonga.IdentityModule1.Web.Infrastructure.Settings;
using Calabonga.IdentityModule1.Web.ViewModels.LogViewModels;
using Calabonga.Microservices.Core.QueryParams;
using Calabonga.Microservices.Core.Validators;
using Calabonga.UnitOfWork;
using Calabonga.UnitOfWork.Controllers.Controllers;
using Calabonga.UnitOfWork.Controllers.Factories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Calabonga.IdentityModule1.Web.Controllers
{
    /// <summary>
    /// WritableController Demo
    /// </summary>
    [Route("api/[controller]")]
    [Authorize]
    public class LogsWritable2Controller : WritableController<LogViewModel, Log, LogCreateViewModel, LogUpdateViewModel, PagedListQueryParams>
    {
        private readonly CurrentAppSettings _appSettings;

        /// <inheritdoc />
        public LogsWritable2Controller(
            IOptions<CurrentAppSettings> appSettings,
            IEntityManagerFactory entityManagerFactory,
            IUnitOfWork<ApplicationDbContext> unitOfWork,
            IMapper mapper)
            : base(entityManagerFactory, unitOfWork, mapper)
        {
            _appSettings = appSettings.Value;
        }

        /// <inheritdoc />
        protected override PermissionValidationResult ValidateQueryParams(PagedListQueryParams queryParams)
        {
            if (queryParams.PageSize <= 0)
            {
                queryParams.PageSize = _appSettings.PageSize;
            }
            return new PermissionValidationResult();
        }
    }
}