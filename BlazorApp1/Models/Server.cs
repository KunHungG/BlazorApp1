using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Server
    {
        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0 ? false : true;
        }
        public int ServerId { get; set; }
        public bool IsOnline { get; set; }
		[Required(ErrorMessage = "Name不可為空白！")]
		public string? Name { get; set; }
		[Required(ErrorMessage = "City不可為空白！")]
		public string? City { get; set; }
    }
}
