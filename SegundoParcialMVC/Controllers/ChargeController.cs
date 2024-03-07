using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SegundoParcialMVC.Models;

namespace SegundoParcialMVC.Controllers
{
    public class ChargeController : Controller
    {
        private readonly string BAPI = "https://localhost:7007/api";
        private readonly HttpClient _httpClient;

        public ChargeController()
        {
            _httpClient = new HttpClient();
        }
        // GET: ChargeController
        public ActionResult Index()
        {
            List<Charge> charge = new List<Charge>();
            //  HttpResponseMessage response = _httpClient.GetAsync($"{BAPI}/categories").Result;
            // if (response.IsSuccessStatusCode)
            // {
            //   string strResponse = response.Content.ReadAsStringAsync().Result;
            // categories = string.IsNullOrEmpty(strResponse) ? categories : JsonConvert.DeserializeObject<List<Category>>(strResponse)!;
            //}
            string jsonChargeResponse = _httpClient.GetStringAsync($"{BAPI}/charge").Result;
            charge = string.IsNullOrEmpty(jsonChargeResponse) ? charge : JsonConvert.DeserializeObject<List<Charge>>(jsonChargeResponse)!;
            return View(charge);

        }

        // GET: ChargeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChargeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChargeController/Create
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

        // GET: ChargeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChargeController/Edit/5
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

        // GET: ChargeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChargeController/Delete/5
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
