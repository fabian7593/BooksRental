﻿using BooksRental.Models;
using BooksRental.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksRental.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ShoppingCartRepository repository = new ShoppingCartRepository();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult addBookToCart(int? id)
        {
            if (id.HasValue) {
                ShoppingCart shoppingCart = new ShoppingCart();
                shoppingCart.AccountId = int.Parse(User.Identity.Name);
                shoppingCart.BookId = id.Value;
                shoppingCart.RentedDate = DateTime.Now;

                repository.Add(shoppingCart);
                repository.SaveChanges();

            }
            return RedirectToAction("Index", "Books");
        }
    }
}