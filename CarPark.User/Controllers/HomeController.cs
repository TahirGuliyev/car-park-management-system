using CarPark.User.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

using MongoDB.Driver;
using MongoDB.Bson;
using CarPark.Models;

namespace CarPark.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            //const string connectionUri = "mongodb+srv://tahir:123456*@carparkcluster.6amdjfh.mongodb.net/CarparkDB?retryWrites=true&w=majority";

            //var settings = MongoClientSettings.FromConnectionString(connectionUri);

            //// Set the ServerApi field of the settings object to Stable API version 1
            //settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            //// Create a new client and connect to the server
            //var client = new MongoClient(settings);

            //// Send a ping to confirm a successful connection
            //try
            //{

            //    var result = client.GetDatabase("CarParkDB").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
            //    var database = client.GetDatabase("CarParkDB");
            //    var collection = database.GetCollection<Test>("Test");
            //    Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            //    var test = new Test()
            //    {
            //        _Id = ObjectId.GenerateNewId(),
            //        NameSurname = "Tahir",
            //        Age = 28,
            //        Address = new List<Address>()
            //        {
            //            new Address
            //            {
            //                Title = "Ev adresim",
            //                Description = "Test",
            //            },
            //            new Address
            //            {
            //                Title = "İş adresim",
            //                Description = "Test",
            //            }

            //        }
            //    };
            //    collection.InsertOne(test);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            _logger.LogInformation("Bu menim ilk logumdur");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}