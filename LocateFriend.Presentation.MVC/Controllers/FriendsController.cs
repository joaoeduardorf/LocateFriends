using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locate.Domain.Entities;
using LocateFriend.Application.Interfaces;
using LocateFriend.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocateFriend.Presentation.MVC.Controllers
{
    public class FriendsController : Controller
    {
        private readonly IFriendAppService _friendAppService;

        public FriendsController(IFriendAppService friendAppService)
        {
            _friendAppService = friendAppService;
        }

        // GET: Friends
        public ActionResult Index()
        {
            return View(_friendAppService.GetAll());
        }

        // GET: Friends/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Friends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Friends/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FriendViewModel friendViewModel)
        {
            try
            {
                // TODO: Add insert logic here
                Friend friend = new Friend { Name = friendViewModel.Name };
                Location location = new Location { X = friendViewModel.X, Y = friendViewModel.Y };
                _friendAppService.Add(friend, location);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Friends/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Friends/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Friends/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Friends/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Friends/Edit/5
        public ActionResult FindFriendsAround(int id)
        {
            
            return View(_friendAppService.LocateFriends(id));
        }
    }
}