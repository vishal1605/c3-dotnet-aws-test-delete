using first_web_api_dot_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace first_web_api_dot_net.Controllers
{
    public class LoginController : Controller
    {
        private readonly TblContext _context;
        public LoginController(TblContext _tblContext)
        {
            _context = _tblContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginProcess(User user)
        {
            Console.WriteLine(user.Email);
            User loginUser = _context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password)!;
            if (loginUser == null)
            {
                return Redirect("Index");
            }
            else
            {
                return Redirect("/Home/Index");
            }
        }
    }
}
