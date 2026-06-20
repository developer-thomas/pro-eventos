using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        
        private IEnumerable<Event> _event = new Event[]
        {
            new Event()
            {
                EventId = 1,
                Theme = "Angular",
                Place = "Santa Catarina",
                Lote = "1º Lote",
                PeopleQuantity = 250,
                EventDate = DateTime.Now.AddDays(2).ToString(),
                ImageUrl = ""
            },
            new Event()
            {
                EventId = 2,
                Theme = "Dotnet",
                Place = "Palhoça",
                Lote = "2º Lote",
                PeopleQuantity = 250,
                EventDate = DateTime.Now.AddDays(3).ToString(),
                ImageUrl = ""
            },
        };

        public EventController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _event.Where(eventCallback => eventCallback.EventId == id);
        }
    }
}
