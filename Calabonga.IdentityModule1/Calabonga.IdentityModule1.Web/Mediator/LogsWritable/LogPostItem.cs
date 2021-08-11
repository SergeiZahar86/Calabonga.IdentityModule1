﻿using AutoMapper;
using Calabonga.AspNetCore.Controllers.Handlers;
using Calabonga.AspNetCore.Controllers.Queries;
using Calabonga.IdentityModule1.Entities;
using Calabonga.IdentityModule1.Web.ViewModels.LogViewModels;
using Calabonga.UnitOfWork;

namespace Calabonga.IdentityModule1.Web.Mediator.LogsWritable
{
    /// <summary>
    /// Request: Log creation
    /// </summary>
    public class LogPostItemRequest : PostItemQuery<Log, LogViewModel, LogCreateViewModel>
    {
        public LogPostItemRequest(LogCreateViewModel model) : base(model)
        {
        }
    }

    /// <summary>
    /// Request: Log creation
    /// </summary>
    public class LogPostItemRequestHandler : PostItemHandlerBase<Log, LogViewModel, LogCreateViewModel>
    {
        public LogPostItemRequestHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
