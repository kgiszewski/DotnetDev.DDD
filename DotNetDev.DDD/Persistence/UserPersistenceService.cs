namespace DotNetDev.DDD.Persistence;

public interface IUserPersistenceService
{
    Task SaveAsync(IUserModel userModel);
    Task<PersistedUser> GetByIdAsync(int id);
}

public class UserPersistenceService : IUserPersistenceService
{
    private readonly DbContext _dbContext;
    
    internal UserPersistenceService(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SaveAsync(IUserModel userModel)
    {
        //EF Code
        var entity = new UserEntity
        {
            Id = userModel.Id
        };
     
        _dbContext.Users.Add(entity);
        await _dbContext.SaveChangesAsync();
    }

    public Task<PersistedUser> GetByIdAsync(int id)
    {
        var entity = _dbContext.Users.SingleOrDefault(x => x.Id == id)!;

        //do some null checks
        return Task.FromResult( new PersistedUser
        {
            Id = entity.Id
        });
    }
}
