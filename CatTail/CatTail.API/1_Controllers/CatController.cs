using CatTail.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatTail.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CatController : ControllerBase
{
    private readonly ICatService _catService;

    public CatController(ICatService catService) => _catService = catService;

    [HttpGet]
    public IActionResult ReturnHello()
    {
        return Ok("Hello");
    }

     [HttpGet("{id}")]
    public IActionResult GetCatById(int id)
    {
        var findCat = _catService.GetCatById(id);

        if(findCat is null) return NotFound();
        
        return Ok(findCat);
    }
}