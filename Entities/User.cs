using System;
namespace Week7_Test.Entities
{
	public class User
	{
		public int ID { get; set; }
		public string Nome { get; set; }
		public string Cognome { get; set; }

		public User()
		{
		}

		public User(string nome, string cognome)
        {
			Nome = nome;
			Cognome = nome;
        }
	}
}

