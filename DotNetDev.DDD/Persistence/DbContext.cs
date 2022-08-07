namespace DotNetDev.DDD.Persistence;

//some sort of DB context like EntityFramework
public class DbContext
{
    public List<UserEntity> Users { get; set; } = new ();

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
