using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
namespace SpaceBattlez
{
	public class Program
	{
		static void Main()
		{
		    IBot bot = new BasicBot();
			Console.WriteLine("ready!");
            
		    string line;
		    while ((line = Console.ReadLine()) != null && line != "")
		    {

		        var data = JsonConvert.DeserializeObject<GameElements.GameState>(line);

		        if (data != null)
		        {
		            var fleetCommands = bot.GameUpdate(data);

		            var message = JsonConvert.SerializeObject(fleetCommands, new JsonSerializerSettings
		            {
		                ContractResolver = new CamelCasePropertyNamesContractResolver()
		            });

		            Console.WriteLine(message);
		        }
		    }
        }
	}
}
