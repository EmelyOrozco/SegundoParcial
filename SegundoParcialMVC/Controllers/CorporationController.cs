using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SegundoParcialMVC.Models;

namespace SegundoParcialMVC.Controllers
{
    public class CorporationController : Controller
    {
        private readonly string BAPI = "https://localhost:7007/api";
        private readonly HttpClient _httpClient;

        public CorporationController()
        {
            _httpClient = new HttpClient();
        }
        // GET: CorporationController
        public ActionResult Index()
        {
            List<Corporation> corporation = new List<Corporation>();
            //  HttpResponseMessage response = _httpClient.GetAsync($"{BAPI}/categories").Result;
            // if (response.IsSuccessStatusCode)
            // {
            //   string strResponse = response.Content.ReadAsStringAsync().Result;
            // categories = string.IsNullOrEmpty(strResponse) ? categories : JsonConvert.DeserializeObject<List<Category>>(strResponse)!;
            //}
            string jsonCorporationResponse = _httpClient.GetStringAsync($"{BAPI}/corporation").Result;
            corporation = string.IsNullOrEmpty(jsonCorporationResponse) ? corporation : JsonConvert.DeserializeObject<List<Corporation>>(jsonCorporationResponse)!;
            return View(corporation);
        }

        // GET: CorporationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CorporationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CorporationController/Create
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

        // GET: CorporationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CorporationController/Edit/5
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

        // GET: CorporationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CorporationController/Delete/5
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
