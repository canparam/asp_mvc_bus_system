using BusSystem.Data.Enum;
using BusSystem.Data.Interfaces;
using BusSystem.Entity.IdentityAccess;
using BusSystem.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BusSystem.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class UserFilterAttribute : ActionFilterAttribute
    {

        private readonly IUserRepository _userRepository;
        private readonly ILogger _logger;

        public UserFilterAttribute(IUserRepository userRepository, ILogger<UserFilterAttribute> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var email = context.HttpContext.User.Identity.Name;
            var user = _userRepository.GetByUserName(email);
            //_logger.LogInformation("Log message {@user}",user);

            if (user.Type == (int)UserType.PARTNER)
            {
                context.Result = new ObjectResult("Bạn không có quyền") { StatusCode = 401 }; 
            }
        }
        




    }
}
