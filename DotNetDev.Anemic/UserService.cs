namespace DotNetDev.Anemic;

public class UserService
{
    public UserModel DoSomething(UserModel model)
    {
        model.Id = 1234;

        return model;
    }

    public void Save(UserModel model)
    {
        //call out to entity framework
    }
}
