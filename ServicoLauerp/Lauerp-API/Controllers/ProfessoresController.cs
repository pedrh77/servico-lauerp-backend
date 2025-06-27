using Lauerp_Domain.DTOs.Professor;
using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class ProfessoresController(IProfessorService _professorServices) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> AdicionaNovoProfessorAsync([FromBody] NovoProfessorDTO request)
    {
        try
        {
            await _professorServices.AddProfessorAsync(request);
            return Created();
        }
        catch (Exception ex)
        {

            throw new Exception("");
        }
    }

    [HttpGet]
    public async Task<IActionResult> ListaProfessoresAsync()
    {
        return Ok(await _professorServices.BuscaProfessoresAsync());
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> ListaProfessoresByIdAsync(int Id)
    {
        return Ok(await _professorServices.BuscaProfessorById(Id));
    }
}
