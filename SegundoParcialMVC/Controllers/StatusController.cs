using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SegundoParcialMVC.Models;

namespace SegundoParcialMVC.Controllers
{
    public class StatusController : Controller
    {
        private readonly string BAPI = "https://localhost:7007/api";
        private readonly HttpClient _httpClient;

        public StatusController()
        {
            _httpClient = new HttpClient();
        }
        // GET: PaymentController
        public ActionResult Index()
        {
            List<Status> status = new List<Status>();
            //  HttpResponseMessage response = _httpClient.GetAsync($"{BAPI}/categories").Result;
            // if (response.IsSuccessStatusCode)
            // {
            //   string strResponse = response.Content.ReadAsStringAsync().Result;
            // categories = string.IsNullOrEmpty(strResponse) ? categories : JsonConvert.DeserializeObject<List<Category>>(strResponse)!;
            //}
            string jsonStatusResponse = _httpClient.GetStringAsync($"{BAPI}/status").Result;
            status = string.IsNullOrEmpty(jsonStatusResponse) ? status : JsonConvert.DeserializeObject<List<Status>>(jsonStatusResponse)!;
            return View(status);
        }

        // GET: StatusController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StatusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatusController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StatusController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StatusController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StatusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StatusController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
