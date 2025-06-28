using Lauerp_Domain.DTOs.Jogador;
using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class JogadoresController(IJogadorService _jogadoresServices) : ControllerBase
{
    [HttpPost]

    public async Task<IActionResult> RegistraJogador(NovoJogadorRequestDTO request)
    {
        await _jogadoresServices.CadastraJogadorAsync(request);
        return Created();
    }


    [HttpPost("Matricula")]
    public async Task<IActionResult> MatriculaJogador(MatricularJogadorAulaRequestDTO request)
    {
        await _jogadoresServices.MatricularJogadorAsync(request);
        return Created();
    }
}
