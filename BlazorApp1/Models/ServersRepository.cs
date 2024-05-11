namespace BlazorApp1.Models
{
	public class ServersRepository
	{
		private static List<Server> gvListServers = new List<Server>()
		{
			new Server { ServerId = 1, Name = "Server1", City = "Toronto" },
			new Server { ServerId = 2, Name = "Server2", City = "Montreal" },
			new Server { ServerId = 3, Name = "Server3", City = "Ottawa" },
			new Server { ServerId = 4, Name = "Server4", City = "Taipei" },
			new Server { ServerId = 5, Name = "Server5", City = "Toronto" },
			new Server { ServerId = 6, Name = "Server6", City = "Montreal" },
			new Server { ServerId = 7, Name = "Server7", City = "Montreal" },
			new Server { ServerId = 8, Name = "Server8", City = "Montreal" },
			new Server { ServerId = 9, Name = "Server9", City = "Montreal" },
			new Server { ServerId = 10, Name = "Server10", City = "Montreal" },
			new Server { ServerId = 11, Name = "Server11", City = "Taipei" },
			new Server { ServerId = 12, Name = "Server12", City = "Taipei" },
			new Server { ServerId = 13, Name = "Server13", City = "Taipei" },
			new Server { ServerId = 14, Name = "Server14", City = "Taipei" },
			new Server { ServerId = 15, Name = "Server15", City = "Taipei" },
			new Server { ServerId = 16, Name = "Server16", City = "Ottawa" },
			new Server { ServerId = 17, Name = "Server17", City = "Ottawa" },
			new Server { ServerId = 18, Name = "Server18", City = "Ottawa" },
			new Server { ServerId = 19, Name = "Server19", City = "Ottawa" },
			new Server { ServerId = 20, Name = "Server20", City = "Ottawa" }
		};

		public static void AddServer(Server myServer)
		{
			var myMaxId = gvListServers.Max(s => s.ServerId);
			myServer.ServerId = myMaxId + 1;
			gvListServers.Add(myServer);
		}

		public static List<Server> GetServers() => gvListServers;

		public static List<Server> GetServersByCity(string myCityName)
		{
			return gvListServers.Where(s => s.City.Equals(myCityName, StringComparison.OrdinalIgnoreCase)).ToList();
		}

		public static Server? GetServerById(int myId)
		{
			var myServer = gvListServers.FirstOrDefault(s => s.ServerId == myId);
			if (myServer != null)
			{
				return new Server
				{
					ServerId = myServer.ServerId,
					Name = myServer.Name,
					City = myServer.City,
					IsOnline = myServer.IsOnline
				};
			}
			return null;
		}

		public static void UpdateServer(int myId, Server myServer)
		{
			if (myId != myServer.ServerId) return;

			var myServerToUpdate = gvListServers.FirstOrDefault(s => s.ServerId == myId);
			if (myServerToUpdate != null)
			{
				myServerToUpdate.IsOnline = myServer.IsOnline;
				myServerToUpdate.Name = myServer.Name;
				myServerToUpdate.City = myServer.City;
			}
		}

		public static void DeleteServer(int myId)
		{
			var myServer = gvListServers.FirstOrDefault(s=>s.ServerId== myId);
            if (myServer != null)
            {
				gvListServers.Remove(myServer);
            }
        }
		
		public static List<Server> SearchServers(string myServerFilter)
		{
			return gvListServers.Where(s=>s.Name.Contains(myServerFilter, StringComparison.OrdinalIgnoreCase)).ToList();
		}
	}
}
