using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission10.Models;

namespace Mission10.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket repo;

        public CartSummaryViewComponent(Basket temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            //Displaying the cart summary
            return View(repo);
        }
    }
}
