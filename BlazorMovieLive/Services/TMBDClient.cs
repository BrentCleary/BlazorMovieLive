namespace BlazorMovieLive.Services
{
	public class TMBDClient
	{
		private readonly HttpClient _httpClient;

		public TMBDClient(HttpClient httpClient, IConfiguration config)
		{

			_httpClient = httpClient;

			_httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
			_httpClient.DefaultRequestHeaders.Accept.Add(new("applciation.json"));

			string apiKey = config["TMDBKey"] ?? throw new Exception("TMBD not found!");
			_httpClient.DefaultRequestHeaders.Authorization = new("Bearer", apiKey);
		}


	}

}