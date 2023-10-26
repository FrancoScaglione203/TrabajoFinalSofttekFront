using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Security.Claims;
using TrabajoFinalSofttekFront.DTOs;
using TrabajoFinalSofttekFront.Base;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace TrabajoFinalSofttekFront.Controllers
{
    public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public LoginController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Ingresar(LoginDto login)
        {
            var baseApi = new BaseApi(_httpClient);
            var token = await baseApi.PostToApi("Login", login);
            var resultadoLogin = token as OkObjectResult;
            var apiResponse = JsonConvert.DeserializeObject<Models.Login>(resultadoLogin.Value.ToString());
            ViewBag.Cuil = apiResponse.Cuil.ToString();

            return View("~/Views/Home/Index.cshtml", apiResponse);

        } 
    }
}
