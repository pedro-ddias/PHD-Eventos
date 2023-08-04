using Microsoft.AspNetCore.Mvc;
using PHD_Eventos.API.Models;

namespace PHD_Eventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]
        {
           new Evento() {
                EventoId = 1,
                Tema = "Argular 12 e .NET 5",
                Local = "Ribeirão das Neves",
                Lote = "1° lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString()
           },
           new Evento() {
                EventoId = 2,
                Tema = "Argular 13 e .NET 6",
                Local = "Ribeirão das Neves",
                Lote = "1° lote",
                QtdPessoas = 150,
                DataEvento = DateTime.Now.AddDays(4).ToString()
           }
        };
    public EventoController()
    {
    }

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
    public string HttpPut(int id)
    {
        return $"Exemplo de PutHttpPut{id}";
    }

    [HttpDelete("{id}")]
    public string HttpDelete(int id)
    {
        return $"Exemplo de HttpDelete{id}";
    }
}
