using aula_02_09.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace aula_02_09.Controllers
{
    public class UserController: Controller
    {
        private UserManager<ApplicationUser> _userManager;

        public UserController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser appUser = new ApplicationUser();
                // Tirar os espaços
                string userName = user.FullName.Replace(" ", "");
                // Tirar todos os acentos
                var normalizedString = userName.Normalize(NormalizationForm.FormD);
                StringBuilder sb = new StringBuilder();
                foreach(char c in normalizedString)
                {
                    if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    {
                        sb.Append(c);
                    }
                }
                userName = sb.ToString().Normalize(NormalizationForm.FormC);
                // Retirar tudo que não for letras e números
                userName = Regex.Replace(userName, @"[^a-zA-Z0-9\s]", "");
                Console.WriteLine(userName);
                
                appUser.UserName = userName;
                appUser.Email = user.Email;
                appUser.NomeCompleto = user.FullName;
                IdentityResult result = await _userManager.CreateAsync(appUser, user.Password);
                if (result.Succeeded)
                {
                    ViewBag.Message = "Usuário cadastrado com sucesso!";
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(user);
        }
    }
}
