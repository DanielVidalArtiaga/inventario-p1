using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maestro.Pages;

public class LogoutModel : PageModel
{
    public async Task<IActionResult> OnGet()
    {
        // Cierra sesión eliminando la cookie
        await HttpContext.SignOutAsync("MyCookieAuth");

        // Redirige al login
        return RedirectToPage("/Login");
    }
}
