using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyChatRoom.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<int, string> Rooms = new Dictionary<int, string>
        {
            {1, "Economia" },
            {2, "Programacion" },
            {3, "Moda" }
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Room(int room)
        {
            return View("Room", room);
        }
    }
}
