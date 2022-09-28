using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OriginTrials.Pages;

public class PopupModel : PageModel
{
    private readonly ILogger<PopupModel> _logger;

    public PopupModel(ILogger<PopupModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
