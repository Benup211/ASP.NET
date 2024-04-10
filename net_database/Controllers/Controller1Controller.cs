using Microsoft.AspNetCore.Mvc;
using net_database.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace net_database.Controllers
{
    public class Controller1Controller : Controller
    {
        private readonly IConfiguration _configuration;
        public Controller1Controller(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            List<Model1Model> model1List = new List<Model1Model>();
            SqlConnection connection = new SqlConnection("Server=localhost;Database=PetExample;User Id=sa;Password=yourStrong(!)Password;");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.[user]", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = (string)reader["name"];
                int age = (int)reader["age"];
                model1List.Add(new Model1Model { Name = name, Age = age });
            }
            connection.Close();
            return View(model1List);
        }
    }
}