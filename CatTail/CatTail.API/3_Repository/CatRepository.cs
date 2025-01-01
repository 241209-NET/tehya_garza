using CatTail.API.Data;
using CatTail.API.Models;

namespace CatTail.API.Repository;

public class CatRepository : ICatRepository
{
    private readonly CatContext _catContext;

    public CatRepository(CatContext catContext) => _catContext = catContext;

    // start writing repo CRUD
    public Cat? GetCatById(int id)
    {
        return _catContext.Cats.Find(id);
    }
}