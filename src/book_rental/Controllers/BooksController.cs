using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace book_rental.Controllers
{
    public class BooksController : Controller
    {
        // GET: /Books/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Books/
        public string Welcome(string name, int id = 1)
        {
            return HtmlEncoder.Default.Encode("Hello " + name + ", times is: " + id);
        }
    }
}
