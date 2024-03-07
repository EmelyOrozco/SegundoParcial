using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SegundoParcialMVC.Models;

namespace SegundoParcialMVC.Controllers
{
    public class ProviderController : Controller
    {
        private readonly string BAPI = "https://localhost:7007/api";
        private readonly HttpClient _httpClient;

        public ProviderController()
        {
            _httpClient = new HttpClient();
        }
        // GET: PaymentController
        public ActionResult Index()
        {
            List<Provider> provider = new List<Provider>();
            //  HttpResponseMessage response = _httpClient.GetAsync($"{BAPI}/categories").Result;
            // if (response.IsSuccessStatusCode)
            // {
            //   string strResponse = response.Content.ReadAsStringAsync().Result;
            // categories = string.IsNullOrEmpty(strResponse) ? categories : JsonConvert.DeserializeObject<List<Category>>(strResponse)!;
            //}
            string jsonProviderResponse = _httpClient.GetStringAsync($"{BAPI}/provider").Result;
            provider = string.IsNullOrEmpty(jsonProviderResponse) ? provider : JsonConvert.DeserializeObject<List<Provider>>(jsonProviderResponse)!;
            return View(provider);
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProviderController/Create
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

        // GET: ProviderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProviderController/Edit/5
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

        // GET: ProviderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProviderController/Delete/5
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
