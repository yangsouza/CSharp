using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class CarroController : ControllerBase
{/*
    private static List<Carro> carros = new List<Carro>
    {
        new Carro("ABC1234", "Carro1"),
        new Carro("DEF5678", "Carro2")
    };
*/


    [HttpGet()]
    [Route("listar")]
    public IActionResult Listar()
    {
        return Ok(carros);
    }

    [HttpGet()]
    [Route("buscar/{placa}")]

    public IActionResult Buscar(string placa)
    {
        CarroController carroTemp =
            carros.Find(carro => carro.Placa == placa) 
        if (carroTemp is not null)
            return Ok(carroTemp);
        else
            return NotFound();
    }

    [HttpPost()]
    [Route("inserir")]
    public IActionResult Inserir(Carro carro)
    {
        carros.Add(carro);
        return Created("", carro);
    }
}
