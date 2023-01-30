using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoFilmes.LIB.Models;

namespace ProjetoFilmes.MVC.Controllers
{
    public class FilmesController : Controller
    {
        string Baseurl = "http://localhost:5125/api/filmes/";

        // GET: FilmesController
        public async Task<IActionResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                var todosFilmes = await client.GetFromJsonAsync<List<Filme>>("");

                return View(todosFilmes);
            }
        }

        // GET: FilmesController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                var Filme = await client.GetFromJsonAsync<Filme>(id.ToString());

                return View(Filme);
            }

        }

        // GET: FilmesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*IFormCollection collection*/ Filme filme)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);

                    await client.PostAsJsonAsync<Filme>("", filme);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View(filme);
            }
        }

        // GET: FilmesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                var Filme = await client.GetFromJsonAsync<Filme>(id.ToString());

                return View(Filme);
            }
        }

        // POST: FilmesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [Bind("FilmeID, Titulo, DataLancamento")] Filme filme)
        {
            if (filme == null)
            {
                return NotFound();
            }

            //checking model state
            if (ModelState.IsValid)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        filme.FilmeID = id;

                        client.BaseAddress = new Uri(Baseurl);
                        //HTTP PUT
                        var result = await client.PutAsJsonAsync<Filme>(id.ToString(), filme);

                        if (result.IsSuccessStatusCode)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                    }
                    return View(filme);
                }
                catch
                {
                    return View(filme);
                }
            }
            return View(filme);
        }

        // GET: FilmesController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                var Filme = await client.GetFromJsonAsync<Filme>(id.ToString());

                return View(Filme);
            }
        }

        // POST: FilmesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, /*IFormCollection collection*/ Filme filme)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    await client.DeleteAsync(id.ToString());

                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
