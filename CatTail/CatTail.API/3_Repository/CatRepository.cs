using CatTail.API.Data;
using CatTail.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CatTail.API.Repository;

public class CatRepository : ICatRepository
{
    private readonly CatContext _catContext;

    public CatRepository(CatContext catContext) => _catContext = catContext;

    // start writing repo CRUD

    // create
    public async Task<Cat> CreateNewCat(Cat newCat)
    {
        
        await _catContext.Cats.AddAsync(newCat);
        await _catContext.SaveChangesAsync();
        return newCat;
    }

    // get by id
    public Cat? GetCatById(int id)
    {
        return _catContext.Cats.Find(id);
    }

    // delete by id
    public void DeleteCatById(int id)
    {
        var cat = GetCatById(id);
        _catContext.Cats.Remove(cat!);
        _catContext.SaveChanges();
    }

    //update by id
    /*public void UpdateCatById(int id)
    {
        var cat = GetCatById(id);
        _catContext.Cats.Add(id);
        _catContext.SaveChanges();
    }*/
}