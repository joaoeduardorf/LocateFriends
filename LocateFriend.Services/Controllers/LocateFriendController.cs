using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocateFriend.Application.Interfaces;
using LocateFriend.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocateFriend.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/LocateFriend")]
    public class LocateFriendController : Controller
    {
        private readonly IFriendAppService _friendAppService;

        public LocateFriendController(IFriendAppService friendAppService)
        {
            _friendAppService = friendAppService;
        }

        // GET: api/LocateFriend/5
        [Authorize("Bearer")]
        [HttpGet("{id}", Name = "GetFriendLocated")]
        public IEnumerable<FriendLocatedViewModel> Get(int id)
        {
            return _friendAppService.LocateFriends(id);
        }
    }
}
