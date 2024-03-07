using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SegundoParcialMVC.Models;

namespace SegundoParcialMVC.Controllers
{
    public class StatementController : Controller
    {
        private readonly string BAPI = "https://localhost:7007/api";
        private readonly HttpClient _httpClient;

        public StatementController()
        {
            _httpClient = new HttpClient();
        }
        // GET: PaymentController
        public ActionResult Index()
        {
            List<Statement> statement = new List<Statement>();
            //  HttpResponseMessage response = _httpClient.GetAsync($"{BAPI}/categories").Result;
            // if (response.IsSuccessStatusCode)
            // {
            //   string strResponse = response.Content.ReadAsStringAsync().Result;
            // categories = string.IsNullOrEmpty(strResponse) ? categories : JsonConvert.DeserializeObject<List<Category>>(strResponse)!;
            //}
            string jsonStatementResponse = _httpClient.GetStringAsync($"{BAPI}/statement").Result;
            statement = string.IsNullOrEmpty(jsonStatementResponse) ? statement : JsonConvert.DeserializeObject<List<Statement>>(jsonStatementResponse)!;
            return View(statement);
        }

        // GET: StatementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StatementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatementController/Create
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

        // GET: StatementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StatementController/Edit/5
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

        // GET: StatementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StatementController/Delete/5
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
