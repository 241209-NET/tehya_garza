using CatTail.API.Models;
using CatTail.API.Repository;
using CatTail.API.Services;
using Moq;

namespace CatTail.TEST;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        Mock<ICatRepository> mockRepo = new();
        CatService catService = new(mockRepo.Object);

        List<Cat> catList = [
            new Cat{Id = 1, Name="Dr.Snow", Age= 5, Sex="F", SNStatus= false, Description="Scruffy long hair white cat, old "},
            new Cat{Id = 2, Name="Mamas", Age=2, Sex="F",SNStatus= false, Description="Short haired calico, mother to many"},
            new Cat{Id = 3, Age= 0, SNStatus= true, Description="grey tabby, very mysterious..."},
        ];

        Cat newCat = new Cat{Id=4, Name= "Gunther", Age=1, SNStatus= true, Description="unknown cat beloved by the neighbor"};

        mockRepo.Setup(repo => repo.CreateNewCat(It.IsAny<Cat>()))
            .Callback((Cat c) => catList.Add(c))
            .ReturnsAsync(newCat);
        // Act
        var myCat = catService.CreateNewCat(newCat);
        // Assert
        Assert.Contains(newCat, catList);
        mockRepo.Verify(x => x.CreateNewCat(It.IsAny<Cat>()), Times.Once());
    }
    
}