using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers;

[ApiController]
public class ShortLinkController : ControllerBase
{
    public JsonResult GetShortLink()
    {
        return new JsonResult(new List<Model>());
    }
}