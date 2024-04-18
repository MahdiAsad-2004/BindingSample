using BindingSample.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BindingSample.Controllers
{
    public class AccountController : Controller
    {
        private string EmailConfirmationKeyCoder = "Sddadkf452158utHhdGDv89RNfId8531";

        public IActionResult Index()
        {
            ViewBag.KeyCoder = EmailConfirmationKeyCoder;
            return View();
        }


        public IActionResult EmailConfirm(string  UserId , string Code)
        {
            Console.WriteLine(UserId);
            var tokenString = AesOperation.DecryptString("Sddadkf452158itHhdGDv89RNfId8531", Code);
            var token = JsonSerializer.Deserialize<Token>(tokenString);
            return Json(token);
        }


    }
}
