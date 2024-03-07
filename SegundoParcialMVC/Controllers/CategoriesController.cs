using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SegundoParcialMVC.Models;
using Newtonsoft.Json;

namespace SegundoParcialMVC.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly string BAPI = "https://localhost:7007/api";
        private readonly HttpClient _httpClient;

        public CategoriesController()
        {
            _httpClient = new HttpClient();
        }
        // GET: categoryController
        public ActionResult Index()
        {
            List<Category> categories = new List<Category>();
          //  HttpResponseMessage response = _httpClient.GetAsync($"{BAPI}/categories").Result;
           // if (response.IsSuccessStatusCode)
           // {
             //   string strResponse = response.Content.ReadAsStringAsync().Result;
               // categories = string.IsNullOrEmpty(strResponse) ? categories : JsonConvert.DeserializeObject<List<Category>>(strResponse)!;
            //}
         string jsonCategoriesResponse = _httpClient.GetStringAsync($"{BAPI}/category").Result;
         categories = string.IsNullOrEmpty(jsonCategoriesResponse) ? categories : JsonConvert.DeserializeObject<List<Category>>(jsonCategoriesResponse)!;
            return View(categories);
        }

        // GET: categoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: categoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: categoryController/Create
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

        // GET: categoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: categoryController/Edit/5
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

        // GET: categoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: categoryController/Delete/5
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
