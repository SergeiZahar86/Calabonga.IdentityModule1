using AutoMapper;
using Calabonga.AspNetCore.Controllers.Handlers;
using Calabonga.AspNetCore.Controllers.Queries;
using Calabonga.IdentityModule1.Entities;
using Calabonga.IdentityModule1.Web.ViewModels.LogViewModels;
using Calabonga.UnitOfWork;
using System;

namespace Calabonga.IdentityModule1.Web.Mediator.LogsWritable
{
    /// <summary>
    /// Request: Log delete
    /// </summary>
    public class LogDeleteItemRequest : DeleteByIdQuery<Log, LogViewModel>
    {
        public LogDeleteItemRequest(Guid id) : base(id)
        {
        }
    }

    /// <summary>
    /// Request: Log delete
    /// </summary>
    public class LogDeleteItemRequestHandler : DeleteByIdHandlerBase<Log, LogViewModel>
    {
        public LogDeleteItemRequestHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
