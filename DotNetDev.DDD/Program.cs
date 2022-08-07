// See https://aka.ms/new-console-template for more information

using DotNetDev.DDD;
using DotNetDev.DDD.Persistence;

Console.WriteLine("Hello, World!");

//inject SomeDependency via DI
var userModel = new UserModelFactory(new SomeDependency(), new UserPersistenceService(new DbContext())).Create(123);

await userModel.SaveAsync();