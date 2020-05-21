using Deonis_lib.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.TestData
{
    /// <summary> Тестовые данные </summary>
    public static class Data
    {
        public static List<Employee> employees { get; } = new List<Employee>()
        {
            new Employee { LastName = "User1", FirstName = "User1", MiddleName = "User1", 
                Login = "User1", Email = "user1@mail.ru", PhoneNubmer = "+7(777)777-77-77", Address = "User1 address" },

            new Employee { LastName = "User2", FirstName = "User2", MiddleName = "User2",
                Login = "User2", Email = "user2@mail.ru", PhoneNubmer = "+7(777)777-77-76", Address = "User2 address" },

            new Employee { LastName = "User3", FirstName = "User3", MiddleName = "User3",
                Login = "User3", Email = "user3@mail.ru", PhoneNubmer = "+7(777)777-77-75", Address = "User3 address" },
        };

        public static List<Order> orders { get; } = new List<Order>()
        {
            new Order { Article = "art1", Employee = "User1", NumberOfTrips = 1, Price = 100, Ticket = "1" },

            new Order { Article = "art2", Employee = "User2", NumberOfTrips = 2, Price = 200, Ticket = "2" },

            new Order { Article = "art3", Employee = "User3", NumberOfTrips = 3, Price = 300, Ticket = "3" },

        };

        public static List<Ticket> tickets { get; } = new List<Ticket>()
        {
            new Ticket { Name = "Name1", Article = "card1", TypeOfTicket = "default", TypeOfTransport = "подзменый", PricePerTrip = 100 },

            new Ticket { Name = "Name2", Article = "card2", TypeOfTicket = "default", TypeOfTransport = "подзменый", PricePerTrip = 200 },

            new Ticket { Name = "Name3", Article = "card3", TypeOfTicket = "default", TypeOfTransport = "подзменый", PricePerTrip = 300 }
        };

        public static List<User> users { get; } = new List<User>()
        {
            new User { Login = "User1", Password = "pass1", Role = "User1"},

            new User { Login = "User2", Password = "pass2", Role = "User2"},

            new User { Login = "User3", Password = "pass3", Role = "User3"},
        };

    }
}
