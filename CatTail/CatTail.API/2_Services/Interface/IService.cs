using CatTail.API.Models;

namespace CatTail.API.Services;

public interface ICatService
{
    Cat? GetCatById(int id);
    Task<Cat> CreateNewCat(Cat newCat);
}