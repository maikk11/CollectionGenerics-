//Creare una List con N oggetti di una classe creata da voi. Creare un’altra List vuota, ciclare la prima lista filtrando gli elementi in base a un criterio scelto da voi e inserire gli elementi nella seconda lista.
using System.Runtime.CompilerServices;

Car m1 = new Car("Captur", 10000, 3000);
Car m2 = new Car("T-Roc", 17000, 5000);
Car m3 = new Car("Panda", 8000, 9000);
Car m4 = new Car("Panda", 8000, 9000);
List<Car> macchine = new List<Car>();
macchine.Add(m1);
macchine.Add(m2);
macchine.Add(m3);
List<Car> macchineCostose = new List<Car>();
foreach(Car macchina in macchine)
{
    if (macchina.Price >= 10000)
    {
        macchineCostose.Add(macchina);
    }
}
foreach(Car macchina in macchineCostose)
{
    Console.WriteLine($"{macchina.Name} {macchina.Price} {macchina.Kilometers}");
}

//Creare un HashSet che contenga oggetti di una classe creata da voi e che non ammetta ripetizioni, sovrascrivendo Equals() e GetHashCode().
HashSet<Car> macchineHash = new HashSet<Car>();
macchineHash.Add(m1);
macchineHash.Add(m2);
macchineHash.Add(m3);
macchineHash.Add(m4);
foreach(Car macchina in macchineHash)
{
    Console.WriteLine($"{macchina.Name} {macchina.Price} {macchina.Kilometers}");
}

//Creare una mappa (Dictionary / Map) con oggetti. Chiedere all’utente di inserire una chiave e provare a cercare l’oggetto corrispondente nella mappa.
Dictionary<string, Car> macchineDic = new Dictionary<string, Car>();
macchineDic.Add(m1.Name,m1);
macchineDic.Add(m2.Name,m2);
macchineDic.Add(m3.Name,m3);
Console.WriteLine("Di che macchina vuoi visualizzare i dati? Captur, T-Roc o Panda");
string inputMacchina = Console.ReadLine();
Console.WriteLine($"{macchineDic[inputMacchina]}");

//Scrivere un programma per aggiornare un elemento specifico di una lista in base al suo indice. Creare una lista di persone, chiedere all’utente quale persona vuole modificare, chiedere i nuovi dati e aggiornare quell’elemento.
List<Person> persone = new List<Person>();
Person p1 = new Person("Paolo", "Rossi", 34);
Person p2 = new Person("Rolando", "Bianchi", 29);
Person p3 = new Person("Roberto", "Verdi", 48);
persone.Add(p1);
persone.Add(p2);
persone.Add(p3);
for(int i = 0; i<persone.Count; i++)
{
    Console.WriteLine($"{i+1}: {persone[i]}");
}
Console.WriteLine($"Inserire indice persona da modificare");
int indiceModifica = int.Parse(Console.ReadLine());
Console.WriteLine($"Inserire nuovo nome");
string name = Console.ReadLine();
Console.WriteLine($"Inserire nuovo cognome");
string surname = Console.ReadLine();
Console.WriteLine($"Inserire nuova età");
int age = int.Parse(Console.ReadLine());
persone[indiceModifica-1].Name=name;
persone[indiceModifica-1].Surname=surname;
persone[indiceModifica-1].Age=age;
Console.WriteLine($"{persone[indiceModifica-1].Name} {persone[indiceModifica-1].Surname} {persone[indiceModifica-1].Age}");

//Scrivere un programma che dichiari una mappa con chiave di tipo string e oggetto a vostra discrezione. Il programma deve prendere in input dei valori, creare un oggetto e aggiungerlo alla mappa. Dopo, provare a rimuovere l’oggetto e cercarlo nuovamente nella mappa.
Dictionary<string, Person> personeDic = new Dictionary<string, Person>();
Console.WriteLine($"Inserire nome");
name = Console.ReadLine();
Console.WriteLine($"Inserire cognome");
surname = Console.ReadLine();
Console.WriteLine($"Inserire età");
age = int.Parse(Console.ReadLine());
Person nuovaPersona = new Person(name,surname,age);
personeDic.Add(nuovaPersona.Name,nuovaPersona);
Console.WriteLine($"{personeDic[nuovaPersona.Name]}");
personeDic.Remove(nuovaPersona.Name);
if (!personeDic.ContainsKey(nuovaPersona.Name))
{
    Console.WriteLine($"Chiave {nuovaPersona.Name} non presente");
}

//Scrivere un programma che crei una lista di elementi e che ne rimuova i duplicati.
macchine.Clear();
macchine.Add(m1);
macchine.Add(m2);
macchine.Add(m3);
macchine.Add(m4);
HashSet<Car> macchineNoDuplicate = new HashSet<Car>(macchine);
foreach(Car mac in macchine)
{
    Console.WriteLine($"{mac.Name} {mac}");
}
foreach(Car mac in macchineNoDuplicate)
{
    Console.WriteLine($"{mac.Name} {mac}");
}
//Scrivere una classe generica che possa accettare qualsiasi tipo di dato.
Generic<string> g1 = new Generic<string>("abc");
Generic<int> g2 = new Generic<int>(1);
Console.WriteLine($"{g1.Value}");
Console.WriteLine($"{g2.Value}");

//Scrivere un metodo generico.