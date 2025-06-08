using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace JokesWebsite.Models
{
	public class Joke
	{
		public int Id { get; set; }
		public required string JokeQuestion { get; set; }
		public required string JokeAnswer { get; set; }
		public Joke()
        {
		//
		// TODO: Add constructor logic here
		//
		}
	}
}
