using first_web_api_dot_net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Diagnostics;

namespace first_web_api_dot_net.Controllers
{
    public class HomeController : Controller
    {
        private readonly TblContext _context;
        public HomeController(TblContext _tblContext)
        {
            _context = _tblContext;
        }

        public IActionResult Index()
        {
            List<RoleName> roleList = _context.RoleName.ToList<RoleName>();
            return View(roleList);
        }

        public IActionResult Users()
        {
            List<User> users = _context.Users.Include(u => u.Roles).ToList();
            return View(users);
        }

        //[HttpPost]
        //public IActionResult CreateUser(User user, List<string> Roles)
        //{
        //    foreach (var role in Roles)
        //    {
        //        Role rol = new Role();
        //        rol.RoleName = role;
        //        user.Roles.Add(rol);
        //    }
        //    _context.Users.Add(user);
        //    _context.SaveChanges();

        //    return Redirect("Index");
        //}
    }
}
