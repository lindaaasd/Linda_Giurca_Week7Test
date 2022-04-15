// See https://aka.ms/new-console-template for more information
using Week7_Test.Entities;
using Week7_Test.Repository;

Console.WriteLine("Hello, World!");

// RISPOSTE DOMANDE TEORICHE

// 1. C
// 2. B
// 3. A, D


try
{ 
    User newUser = new User();
    Console.WriteLine("Inserisci un nome");
    newUser.Nome = Console.ReadLine();

    VerificaNome(newUser);
}
catch(UserException ex)
{
    Console.WriteLine(ex.Message);
}

void VerificaNome(User user){

    if( user.Nome == "Linda")
    {
        Console.WriteLine("Abbiamo trovato Linda!");
    } else
    {
        throw new UserException(user.Nome);
    }
}

GestioneDB repoUser = new GestioneDB();
List<User> Users = repoUser.GetAll();

void StampaUsers()
{
    foreach (var user in Users)
    {
        Console.WriteLine(user);
    }
}

Console.ReadLine();
