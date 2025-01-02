namespace CatTail.API.Models;

public class Cat{
    public int Id { get; set; }
    public string? Name { get; set; }   // may not be given a name initially
    public string? Sex { get; set; }      // may not be known initially so made into string instead of char
    public int Age { get; set; }       // may not be known initially, in context of years (kittens and unknown cats can be set to 0)
    public bool SNStatus { get; set; }  // set to false unless known otherwise
    public required string Description { get; set; }    // color and fur description and other info; helps with identification

}