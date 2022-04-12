using HRMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HRMVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string UserName, string Password)
        {
            UserLogin User = new UserLogin();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"http://65.108.16.103:13000/api/ar/login/{UserName}/{Password}"))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        User = JsonConvert.DeserializeObject<UserLogin>(apiResponse);
                        return Redirect("~/Home/Index");
                    }
                    else
                    {
                        ViewBag.StatusCode = response.StatusCode;
                        return Redirect("~/Account/Login");
                    }

                }
            }
        }

        //[HttpPost]
        //public IActionResult Login(string username, string Psw)
        //{
        //    UserLogin User = null;

        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://65.108.16.103:13000/api/ar/login/");
        //        //HTTP GET
        //        var responseTask = client.GetAsync($"{username}/{Psw}");
        //        responseTask.Wait();

        //        var result = responseTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            var readTask = result.Content.ReadAsAsync<UserLogin>();
        //            readTask.Wait();

        //            User = readTask.Result;

        //        }
        //    }
        //    return View(User);
        //}

        //[HttpPost]
        //public ActionResult Login(UserLogin user)
        //{
        //    using (var client = new HttpClient())
        //    {

        //        //HTTP POST
        //        var postTask = client.PostAsJsonAsync<UserLogin>("http://65.108.16.103:13000/api/ar/login/", user);
        //        postTask.Wait();

        //        var result = postTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            return Redirect("~/Home/Index");
        //        }
        //    }

        //    ModelState.AddModelError(string.Empty, "Wrong Username or Pass.");

        //    return Redirect("~/Account/Login");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Login(UserLogin user)
        //{
        //    using (var httpClient = new HttpClient())
        //    {
        //        StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

        //        using (var response = await httpClient.PostAsync("http://65.108.16.103:13000/api/ar/login/", content))
        //        {
        //            string token = await response.Content.ReadAsStringAsync();
        //            if (token == "Success")
        //            {
        //                return Redirect("~/Home/Index");
        //            }
        //        }
        //    }
        //    //ModelState.AddModelError(string.Empty, "Wrong Username or Pass.");

        //    return Redirect("~/Account/Login");
        //}
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Profile()
        {
            return View();
        }
    }
}
