using DotNetDev.DDD.Persistence;

namespace DotNetDev.DDD;

public interface IUserModel
{
    public int Id { get; } //no setter
    public string Name { get; } //no setter
    public void ChangeName(string name);
    public Task SaveAsync();
}

public class UserModel : IUserModel
{
    private readonly ISomeDependency _someDependency;
    private readonly IUserPersistenceService _userPersistenceService;
    public int Id { get; private set; } //private setter
    public string Name { get; private set; } = null!;//private setter


    public void ChangeName(string name)
    {
        //copious amounts of validation goes here
        Name = name;
    }

    public async Task SaveAsync()
    {
        //pass current instance to the persistence
        await _userPersistenceService.SaveAsync(this);
    }

    //internal ctor, ISomeDependency from factory
    internal UserModel(ISomeDependency someDependency, IUserPersistenceService userPersistenceService)
    {
        _someDependency = someDependency;
        _userPersistenceService = userPersistenceService;
    }
    
    internal void FromId(int id) //hydration method used in factory
    {
        Id = id;
    }
}



