using Microsoft.AspNetCore.Mvc;
using Tuan6.Models.DataModels;

namespace Tuan6.Controllers
{
    public class MemberController : Controller
    {
        public static readonly List<Member> members = new List<Member>()
        {
            new Member{MemberId = Guid.NewGuid().ToString(), Username = "member1", Fullname = "Thanh viên 1", Password = "123456", Email = "tv1@gmail.com"},
            new Member{MemberId = Guid.NewGuid().ToString(), Username = "member2", Fullname = "Thanh viên 2", Password = "123456", Email = "tv2@gmail.com"},
            new Member{MemberId = Guid.NewGuid().ToString(), Username = "member3", Fullname = "Thanh viên 3", Password = "123456", Email = "tv3@gmail.com"},
            new Member{MemberId = Guid.NewGuid().ToString(), Username = "member4", Fullname = "Thanh viên 4", Password = "123456", Email = "tv4@gmail.com"},
            new Member{MemberId = Guid.NewGuid().ToString(), Username = "member5", Fullname = "Thanh viên 5", Password = "123456", Email = "tv5@gmail.com"},
        };

        public IActionResult Index()
        {
            var member = new Member();
            member.MemberId = Guid.NewGuid().ToString();
            member.Username = "trinhvanchung";
            member.Fullname = "Trinh Van Chung";
            member.Password = "password";
            member.Email = "chungtrinhvan@gmail.com";
            return View(member);
        }

        public IActionResult GetMembers()
        {
            ViewBag.members = members;
            return View();
        }

        //Default là GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]//hành động gọi ứng với method là post
        public IActionResult Create(Member member)
        {
            member.MemberId = Guid.NewGuid().ToString();
            members.Add(member);
            return RedirectToAction("GetMembers");
        }
    }
}
