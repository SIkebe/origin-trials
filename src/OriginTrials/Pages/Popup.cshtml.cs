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
        // For localhost only
        HttpContext.Response.Headers.Add("origin-trial", "An7ZwdRCMPWw6SzSNARtp608Rn+RJm2wslsIpstPa58tN//rGpkC/oDbk6NBaKfcXo8Lid3icaV1435D3vLAjwIAAABWeyJvcmlnaW4iOiJodHRwczovL2xvY2FsaG9zdDo3MTMwIiwiZmVhdHVyZSI6IkhUTUxQb3B1cEF0dHJpYnV0ZSIsImV4cGlyeSI6MTY4MDY1Mjc5OX0=");
    }
}
