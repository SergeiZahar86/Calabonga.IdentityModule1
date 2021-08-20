using Calabonga.IdentityModule1.Web.Mediator.Account;
using Calabonga.IdentityModule1.Web.ViewModels.AccountViewModels;
using Calabonga.OperationResults;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Calabonga.IdentityModule1.Web.Controllers
{
    /// <summary>
    /// Account Controller
    /// </summary>
    [Route("api/[controller]")]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Register controller
        /// </summary>
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Register new user. Success registration returns UserProfile for new user.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        [AllowAnonymous]
        [ProducesResponseType(200, Type = typeof(OperationResult<UserProfileViewModel>))]
        public async Task<ActionResult<OperationResult<UserProfileViewModel>>> Register([FromBody] RegisterViewModel model)
        {
            HttpResponse resp = HttpContext.Response;
            string cookie = GetCookieValueFromResponse(resp, ".AspNetCore.Cookie");

            return Ok(await _mediator.Send(new RegisterRequest(model), HttpContext.RequestAborted));
        }

        /// <summary>
        /// Returns profile information for authenticated user
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        [ProducesResponseType(200, Type = typeof(OperationResult<UserProfileViewModel>))]
        public async Task<ActionResult<OperationResult<UserProfileViewModel>>> Profile()
        {
            return await _mediator.Send(new ProfileRequest(), HttpContext.RequestAborted);
        }

        /// <summary>
        /// Получение токена из Cookie
        /// </summary>
        /// <param name="response"></param>
        /// <param name="cookieName"></param>
        /// <returns></returns>
        private string GetCookieValueFromResponse(HttpResponse response, string cookieName)
        {
            foreach (var headers in response.Headers.Values)
                foreach (var header in headers)
                    if (header.StartsWith($"{cookieName}="))
                    {
                        var p1 = header.IndexOf('=');
                        var p2 = header.IndexOf(';');
                        return header.Substring(p1 + 1, p2 - p1 - 1);
                    }
            return null;
        }
    }
}