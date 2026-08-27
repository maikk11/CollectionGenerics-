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

//Scrivere un programma per aggiornare un elemento specifico di una lista in base al suo indice. Creare una lista di persone, chiedere all’utente quale persona vuole modificare, chiedere i nuovi dati e aggiornare quell’elemento.

//Scrivere un programma che dichiari una mappa con chiave di tipo string e oggetto a vostra discrezione. Il programma deve prendere in input dei valori, creare un oggetto e aggiungerlo alla mappa. Dopo, provare a rimuovere l’oggetto e cercarlo nuovamente nella mappa.

//Scrivere un programma che crei una lista di elementi e che ne rimuova i duplicati.

//Scrivere una classe generica che possa accettare qualsiasi tipo di dato.

//Scrivere un metodo generico.