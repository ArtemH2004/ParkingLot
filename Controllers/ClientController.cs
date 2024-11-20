//// Controllers/ClientController.cs
//using Microsoft.AspNetCore.Mvc;
//using ParkingLotApp.Models;

//namespace ParkingLotApp.Controllers
//{
//    public class ClientController : Controller
//    {
//        public ActionResult Index()
//        {
//            // Создайте моковые данные
//            var clients = new List<Client>
//            {
//                new Client { ClientId = 1,
//                    LastName = "Петров",
//                    FirstName = "Петр",
//                    MiddleName = "Петрович",
//                    Phone = "987654321",
//                    Address = "г. Москва, ул. Лермонтова, 5",
//                    PassportData = "9876-543210",
//                    HasDiscount = true},
//            };

//            return View(clients);
//        }
//    }
//}
