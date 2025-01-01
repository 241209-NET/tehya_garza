namespace CatTail.API.Models;

public class Cat{
    public int Id { get; set; }
    public required string Name { get; set; }
    public char Sex { get; set; }
    public int Age { get; set; }

}