using AutoMapper;
using Calabonga.AspNetCore.Controllers.Handlers;
using Calabonga.AspNetCore.Controllers.Queries;
using Calabonga.IdentityModule1.Entities;
using Calabonga.IdentityModule1.Web.ViewModels.LogViewModels;
using Calabonga.UnitOfWork;
using System;

namespace Calabonga.IdentityModule1.Web.Mediator.LogsReadonly
{
    /// <summary>
    /// Request for Log by Identifier
    /// </summary>
    public class LogGetByIdRequest : GetByIdQuery<LogViewModel>
    {
        public LogGetByIdRequest(Guid id) : base(id)
        {
        }
    }

    /// <summary>
    /// Response for  Request for Log by Identifier
    /// </summary>
    public class LogGetByIdRequestHandler : GetByIdHandlerBase<LogGetByIdRequest, Log, LogViewModel>
    {
        public LogGetByIdRequestHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
