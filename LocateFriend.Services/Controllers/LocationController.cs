using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locate.Domain.Entities;
using LocateFriend.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocateFriend.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Location")]
    public class LocationController : Controller
    {
        private readonly ILocationAppService _locationAppService;

        public LocationController(ILocationAppService locationAppService)
        {
            _locationAppService = locationAppService;
        }


        // GET: api/Location/5
        [HttpGet("{id}", Name = "GetLocation")]
        public Location Get(int id)
        {
            return _locationAppService.GetById(id);
        }
    }
}
