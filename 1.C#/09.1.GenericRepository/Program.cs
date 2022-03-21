// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using GenericRepository.Entities;
using GenericRepository.Repositories;


var carDb = new List<Car>()
{
    new Car() { Id = 1, Make = "Toyota", Model = "Corolla", Year = 2015},
    new Car() { Id = 2, Make = "BMW", Model = "5 series", Year = 2012},
    new Car() { Id = 3, Make = "Skoda", Model = "Superb", Year = 2014}
};

var userDb = new List<User>()
{
    new User() { Id = 1, FirstName = "John", LastName = "Smith", Age = 25 },
    new User() { Id = 2, FirstName = "Adam", LastName = "Hogan", Age = 31 },
    new User() { Id = 3, FirstName = "Sarah", LastName= "Conor", Age = 17}
};



IBaseRepository<Car> carRepository = new BaseRepository<Car>();
carRepository.AddRange(carDb);
var car = carRepository.GetById(2);



IUserRepository userRepository = new UserRepository();
userRepository.AddRange(userDb);
var user = userRepository.GetById(1);
user.Age = 26;//here we have changed age for John Smith in the list from repository. Here we have a reference
var adultUsers = userRepository.GetAdults();
userRepository.Remove(2);

