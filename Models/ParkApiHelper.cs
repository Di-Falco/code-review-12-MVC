using System.Threading.Tasks;
using RestSharp;

namespace ParksMVC.Models
{
  class ParkApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"parks", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"messages/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newPark)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest("http://localhost:5002/api");
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newPark);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newPark)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"parks/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newPark);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"parks/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
    
  }
}