namespace BlazorApp1.Models
{
	public class CitiesRepository
	{
		private static List<string> gvListCities = new List<string>()
		{
			"Toronto",
			"Montreal",
			"Ottawa",
			"Calgary",
			"Halifax",
			"Taipei"
		};
		public static List<string> GetCities() => gvListCities;
	}
}
