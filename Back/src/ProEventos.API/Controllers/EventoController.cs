using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public EventoController()
    {
    }

    public IEnumerable<Evento> _evento = new Evento[]{
        new Evento(){
            EventoId = 1,
            Tema = "Angulas 11 e .NET 6",
            Local = "São Paulo-SP",
            Lote = "Primeiro lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
            ImagemURL = "foto.png"
        },
        new Evento(){
            EventoId = 2,
            Tema = "Angulas e suas novidades",
            Local = "São Paulo-SP",
            Lote = "Primeiro lote",
            QtdPessoas = 350,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
            ImagemURL = "foto1.png"
        }
    };

    [HttpGet]
    public IEnumerable<Evento> Get()
    {       
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {       
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {       
        return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {       
        return $"Exemplo de Put com o id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {       
        return $"Exemplo de Delete com o id = {id}";
    }
}
