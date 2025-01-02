using CatTail.API.Models;
using CatTail.API.Repository;

namespace CatTail.API.Services;

public class CatService : ICatService
{
    private readonly ICatRepository _catRepository;

    public CatService(ICatRepository catRepository) => _catRepository = catRepository;

    public async Task<Cat> CreateNewCat(Cat newCat)
    {
        return await _catRepository.CreateNewCat(newCat);
    }
     public Cat? GetCatById(int id)
    {
        if(id < 1) return null;
        return _catRepository.GetCatById(id);
    }

     public Cat? DeleteCatById(int id)
    {
        var cat = GetCatById(id);
        if(cat is not null) _catRepository.DeleteCatById(id);
        return cat;
    }
    /*public Cat? UpdateCatById(int id)
    {
        var cat = GetCatById(id);
        if(cat is not null) _catRepository.UpdateCatById(id);
        return cat;
    }*/
    
}