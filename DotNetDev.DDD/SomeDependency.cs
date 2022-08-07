namespace DotNetDev.DDD;

public interface ISomeDependency
{
    void DoSomething();
}

public class SomeDependency : ISomeDependency
{
    public void DoSomething()
    {
        throw new NotImplementedException();
    }
}