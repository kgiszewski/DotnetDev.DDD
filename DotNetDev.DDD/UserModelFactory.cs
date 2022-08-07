using DotNetDev.DDD.Persistence;

namespace DotNetDev.DDD;

public class UserModelFactory 
{
    private readonly ISomeDependency _someDependency;
    private readonly IUserPersistenceService _userPersistenceService;

    public UserModelFactory(ISomeDependency someDependency, IUserPersistenceService userPersistenceService) 
    {
        _someDependency = someDependency;
        _userPersistenceService = userPersistenceService;
    }

    public IUserModel Create(int id)
    {
        var model = new UserModel(_someDependency, _userPersistenceService);
 
        model.FromId(id);
    
        return model;
    }
}