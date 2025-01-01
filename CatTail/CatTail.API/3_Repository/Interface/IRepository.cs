using CatTail.API.Models;

namespace CatTail.API.Repository;

public interface ICatRepository
{
    Cat? GetCatById(int id); 
    
}