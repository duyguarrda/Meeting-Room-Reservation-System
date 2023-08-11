// See https://aka.ms/new-console-template for more information
using Azure;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using EntitiesLayer;

Console.WriteLine("Hello, World!");
User user1 = new User();
IUserService _userService = new UserManager(new EfUserDal());
var age =_userService.CalculateAge(user1);
Console.WriteLine($"Yaşınız: {age}");