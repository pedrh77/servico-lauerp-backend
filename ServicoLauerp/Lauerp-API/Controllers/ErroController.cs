using Lauerp_API.ViewModel;
using Lauerp_Domain.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Lauerp_API.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class ErroController : ControllerBase
{

    [Route("erro")]
    public ErrorViewModel Erro()
    {
        IExceptionHandlerFeature contexto = HttpContext.Features.Get<IExceptionHandlerFeature>();
        Exception excecao = contexto?.Error!;

        HttpStatusCode httpStatusCode = excecao switch
        {
            EmptyValueException _ => HttpStatusCode.NoContent,
            DbUpdateException _ =>HttpStatusCode.BadRequest,
          _ => HttpStatusCode.NotFound
        };

        Response.StatusCode = (int)httpStatusCode;

        return new ErrorViewModel(Response.StatusCode.ToString(), excecao.Message, excecao.Data);
    }
}
