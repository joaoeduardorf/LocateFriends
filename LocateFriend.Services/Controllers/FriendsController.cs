using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locate.Domain.Entities;
using LocateFriend.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocateFriend.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Friends")]
    public class FriendsController : Controller
    {
        private readonly IFriendAppService _friendAppService;

        public FriendsController(IFriendAppService friendAppService)
        {
            _friendAppService = friendAppService;
        }

        // GET: api/Friends
        [Authorize("Bearer")]
        [HttpGet]
        public IEnumerable<Friend> Get()
        {
            return _friendAppService.GetAll();
        }

        // GET: api/Friends/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Friends
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Friends/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
