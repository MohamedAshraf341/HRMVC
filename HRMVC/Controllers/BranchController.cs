using HRMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HRMVC.Controllers
{
    public class BranchController : Controller
    {
        //Hosted web API REST Service base url
        string Baseurl = "http://65.108.16.103:13000/";
        //GetAll
        public async Task<IActionResult> Index()
        {

            List<atttables> att = new List<atttables>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(Baseurl + "api/atttables?flag=0"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    att = JsonConvert.DeserializeObject<List<atttables>>(apiResponse);
                }
            }
            return View(att);
        }
        //Get By ID
        public ActionResult GetByID()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetByID(int id)
        {
            atttables att = new atttables();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(Baseurl + "api/atttables/" + id + "?flag=0"))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        att = JsonConvert.DeserializeObject<atttables>(apiResponse);
                    }
                    else
                        ViewBag.StatusCode = response.StatusCode;
                }
            }
            return View(att);
        }
        //get Detail
        //[HttpGet]
        //[Route("Detail/{id}")]
        [HttpPost]
        public JsonResult Detail(int id)
        {
            atttables att = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                //HTTP GET
                var responseTask = client.GetAsync($"api/atttables/{id}?flag=0");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<atttables>();
                    readTask.Wait();

                    att = readTask.Result;

                }
            }
            return Json(att);
        }
        //Add
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(atttables att)
        {
            atttables attInfo = new atttables();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(att), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(Baseurl + "api/atttables?flag=0", content))
                {
                    string attResponse = await response.Content.ReadAsStringAsync();
                    attInfo = JsonConvert.DeserializeObject<atttables>(attResponse);
                }
            }
            return View(attInfo);
        }
        public ActionResult AddNew()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNew(atttables att)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<atttables>("api/atttables?flag=0", att);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(att);
        }
        //Update
        public ActionResult Edit(int id)
        {
            atttables att = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                //HTTP GET
                var responseTask = client.GetAsync($"api/atttables/{id}?flag=0");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<atttables>();
                    readTask.Wait();

                    att = readTask.Result;
                }
            }
            return View(att);
        }
        [HttpPost]
        public ActionResult Edit(atttables att)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(att.Id.ToString()), "Id");
                

                //HTTP POST
                var putTask = client.PutAsJsonAsync<atttables>($"api/atttables/{att.Id}?flag=0", att);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(att);
        }
        //delete
        
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                //HTTP DELETE
                var deleteTask = client.DeleteAsync($"api/atttables/{id}?flag=0");
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
    }
}
