using CatTail.API.Models;
using CatTail.API.Repository;
using CatTail.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatTail.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CatController : ControllerBase
{
    private readonly ICatService _catService;

    public CatController(ICatService catService) => _catService = catService;

    // Create: create new cat
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

    /*// Update: update existing cat by id
    [HttpPut("{id}")]
    public async Task<ActionResult<Cat>> UpdateCatById(int id, [FromBody] Cat cat)
    {
        var updateCat = _catService.GetCatById(id);
        if(updateCat is null) return NotFound();
        
        return Ok(updateCat);

    }*/


     // Delete: delete cat by id
     [HttpDelete]
    public IActionResult DeleteCatById(int id)
    {
        var deleteCat = _catService.DeleteCatById(id);

        if(deleteCat is null) return NotFound();
        
        return Ok(deleteCat);
    }

    
}