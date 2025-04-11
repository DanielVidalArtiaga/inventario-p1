
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace Maestro.Pages;

public class UsuarioModel : PageModel
{
    private readonly ILogger<UsuarioModel> _logger;

    public UsuarioModel(ILogger<UsuarioModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}