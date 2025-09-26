// See https://aka.ms/new-console-template for more information
using GenerqueDemo;
using GenerqueDemo.Models;

Console.WriteLine("Hello, World!");

//Personnage personnage = new Personnage();
//personnage.Name = "PtiteGoutte";
//personnage.FirstName = "Justine";
//personnage.BirthDate = DateTime.Now;

//Meubles meubles = new Meubles();
//meubles.Marque = "Giocomo";
//meubles.Prix = 456985;
//meubles.EstAntiquite = true;

//Animal animal = new Animal();
//animal.Name = "Bernie";
//animal.Description = "Un drôle de chien brun sans oreilles";

//Console.WriteLine(personnage.Name);
//Console.WriteLine(personnage.FirstName);
//Console.WriteLine(personnage.BirthDate);
//Console.WriteLine(meubles.Marque);
//Console.WriteLine(meubles.Prix + "€");
//Console.WriteLine(meubles.EstAntiquite);

//personnage.getView();
//meubles.getView();

//UIManager.DisplayInfo<Personnage>(personnage);
//UIManager.DisplayInfo<Meubles>(meubles);
//UIManager.DisplayInfo<Animal>(animal);
//Dictionary<string, object> lesinfosPourLefou = new();

//lesinfosPourLefou.Add("Name", "Lefou");
//lesinfosPourLefou.Add("FirstName", "Du centre");
//lesinfosPourLefou.Add("BirthDate", new DateTime(1975, 3, 2));

//Personnage leFou = UIManager.Usine<Personnage>(lesinfosPourLefou);

//Console.WriteLine(leFou);

//Je voudrais transmettre un dictionnaire clé valeur qui contient les infos de mon futur objet
List<int> list = new List<int>();
list.Add(4);
list.Remove(6);


MyList<int> listDentier = new MyList<int>();

 
  // ça passe pas ok
double valeur =(double)  listDentier.Get(0);
Console.WriteLine(listDentier.Get(0));
listDentier.Remove(4);

// créer l'objet et le renvoyer
Console.ReadKey();
