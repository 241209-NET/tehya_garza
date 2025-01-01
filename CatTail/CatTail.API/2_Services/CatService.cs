using CatTail.API.Models;
using CatTail.API.Repository;

namespace CatTail.API.Services;

public class CatService : ICatService
{
    private readonly ICatRepository _catRepository;

    public CatService(ICatRepository catRepository) => _catRepository = catRepository;

     public Cat? GetCatById(int id)
    {
        if(id < 1) return null;
        return _catRepository.GetCatById(id);
    }
}