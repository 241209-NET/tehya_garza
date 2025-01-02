using CatTail.API.Models;

namespace CatTail.API.Repository;

public interface ICatRepository
{
    Task<Cat> CreateNewCat(Cat newCat);
    Cat? GetCatById(int id); 
    void DeleteCatById(int id);
    //void UpdateCatById(int id);
    
}