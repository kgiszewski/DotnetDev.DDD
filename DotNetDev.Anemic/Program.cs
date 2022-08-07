// See https://aka.ms/new-console-template for more information

using DotNetDev.Anemic;

Console.WriteLine("Hello, World!");

var userModel = new UserModel();
var userService = new UserService();

//the service is in control
userService.DoSomething(userModel);
userService.Save(userModel);
