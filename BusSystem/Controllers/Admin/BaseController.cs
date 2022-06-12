using BusSystem.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystem.Controllers.Admin
{
    [Authorize]
    [TypeFilter(typeof(UserFilterAttribute))]
    public class BaseController : Controller
    {
        
    }
}
