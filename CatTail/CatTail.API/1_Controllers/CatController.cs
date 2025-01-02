using CatTail.API.Models;
using CatTail.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatTail.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CatController : ControllerBase
{
    private readonly ICatService _catService;

    public CatController(ICatService catService) => _catService = catService;

    [HttpPost]
    public async Task<IActionResult> CreateNewCat(Cat newCat)
    {
        var cat = _catService.CreateNewCat(newCat);
        return Ok(await cat);
    }

    // Retrieve: get cat by id
     [HttpGet("{id}")]
    public IActionResult GetCatById(int id)
    {
        var findCat = _catService.GetCatById(id);

        if(findCat is null) return NotFound();
        
        return Ok(findCat);
    }
}