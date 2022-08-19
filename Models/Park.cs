using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ParksMVC.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string PhotoUrl { get; set; }

    public static List<Park> GetParks()
    {
      var apiCallTask = ParkApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());

      return parkList;
    }

    public static Park GetDetails(int id)
    {
      var apiCallTask = ParkApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Park park = JsonConvert.DeserializeObject<Park>(jsonResponse.ToString());

      return park;
    }

    public static async Task Post(Park park)
    {
      string jsonMessage = JsonConvert.SerializeObject(park);
      await Task.Run(() => ParkApiHelper.Post(jsonMessage));
    }

    public static async Task Put(Park park)
    {
      string jsonMessage = JsonConvert.SerializeObject(park);
      await Task.Run(() => ParkApiHelper.Put(park.ParkId, jsonMessage));
    }

    public static async Task Delete(int id)
    {
      await Task.Run(() => ParkApiHelper.Delete(id));
    }

  }
}