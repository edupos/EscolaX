using AutoMapper;
using EscolaX.Application.Interface;
using EscolaX.Domain.Entities;
using EscolaX.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EscolaX.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserAppService _userApp;

        public UserController(IUserAppService userApp)
        {
            _userApp = userApp;
        }

        // GET: User
        public ActionResult Index()
        {
            var userViewModel = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(_userApp.GetAll());

            return View(userViewModel);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel user)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var userDomain = Mapper.Map<UserViewModel, User>(user);
                    _userApp.Add(userDomain);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(user);
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
