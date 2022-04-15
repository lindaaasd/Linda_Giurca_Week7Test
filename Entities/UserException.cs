using System;
namespace Week7_Test.Entities
{
	public class UserException:Exception
	{

		public User Nome { get; set; }
		public User Cognome { get; set; }

		public UserException()
		{
		}

		public UserException(string nome): base(String.Format($"{nome}non è presente nella ns anagrafica"))
        {

        }
	}
}

