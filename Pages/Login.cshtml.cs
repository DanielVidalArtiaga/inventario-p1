using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class LoginModel : PageModel
{
    [BindProperty]
    public string? Username { get; set; }

    [BindProperty]
    public string? Password { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (Username == "admin" && Password == "123")
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, Username)
            };

            var identity = new ClaimsIdentity(claims, "MyCookieAuth");
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("MyCookieAuth", principal);

            return RedirectToPage("/Index");
        }

        ModelState.AddModelError("", "Usuario o contraseña incorrectos");
        return Page();
    }
}
