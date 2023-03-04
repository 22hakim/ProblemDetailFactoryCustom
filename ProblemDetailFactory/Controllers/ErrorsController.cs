using System;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ProblemDetailFactory.Controllers;

[ApiController]
public class ErrorsController : ControllerBase
{
    [Route("/error"),HttpGet]
    public IActionResult Index()
    {
        var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error.Message;
        return Problem(title:exceptionHandlerFeature);
    }
}

