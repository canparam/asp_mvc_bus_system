using BusSystem.Data.Enum;
using BusSystem.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class PartnerFilerAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger _logger;

        public PartnerFilerAttribute(IUserRepository userRepository, ILogger<PartnerFilerAttribute> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;

            if (!user.Identity.IsAuthenticated)
            {
                // it isn't needed to set unauthorized result 
                // as the base class already requires the user to be authenticated
                // this also makes redirect to a login page work properly
                context.Result = new RedirectResult("/login");
                return;
            }
            //var check = _userRepository.GetByUserName(user.Identity.Name);
            //if (check.Type == (int)UserType.ADMIN)
            //{
            //    context.Result = new RedirectResult("/");
            //}
        }
    }
}
