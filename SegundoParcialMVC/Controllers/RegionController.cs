using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SegundoParcialMVC.Models;

namespace SegundoParcialMVC.Controllers
{
    public class RegionController : Controller
    {
        private readonly string BAPI = "https://localhost:7007/api";
        private readonly HttpClient _httpClient;

        public RegionController()
        {
            _httpClient = new HttpClient();
        }
        // GET: PaymentController
        public ActionResult Index()
        {
            List<Region> region = new List<Region>();
            //  HttpResponseMessage response = _httpClient.GetAsync($"{BAPI}/categories").Result;
            // if (response.IsSuccessStatusCode)
            // {
            //   string strResponse = response.Content.ReadAsStringAsync().Result;
            // categories = string.IsNullOrEmpty(strResponse) ? categories : JsonConvert.DeserializeObject<List<Category>>(strResponse)!;
            //}
            string jsonRegionResponse = _httpClient.GetStringAsync($"{BAPI}/region").Result;
            region = string.IsNullOrEmpty(jsonRegionResponse) ? region : JsonConvert.DeserializeObject<List<Region>>(jsonRegionResponse)!;
            return View(region);
        }

        // GET: RegionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegionController/Create
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

        // GET: RegionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegionController/Edit/5
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

        // GET: RegionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegionController/Delete/5
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
