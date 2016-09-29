﻿using SportStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SportStore.WebUI.Binders
{
    public class CartModelBinder:IModelBinder
    {
        private const string sessionKey = "Cart";
        public object BindModel(ControllerContext controllerContext,ModelBindingContext bindingContext)
        {
            //get the cart frim the session
            Cart cart = (Cart)controllerContext.HttpContext.Session[sessionKey];
            //create the Cart if there wasn't one in the session data
            if(cart == null)
            {
                cart = new Cart();
                controllerContext.HttpContext.Session[sessionKey] = cart;
            }
            //return the cart
            return cart;
        }
    }
}