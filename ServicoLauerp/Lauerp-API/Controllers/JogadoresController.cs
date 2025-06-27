using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class JogadoresController(IJogadorService _jogadoresServices) : ControllerBase
{

}
