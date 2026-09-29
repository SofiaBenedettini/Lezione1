using BlaisePascal.Lezione1.Domain;

public class Program
{ 
    public static void Main()
    {

        //Stampo a video il messaggio per chiedere il nome del cliente
        Console.WriteLine("Inserisci il nome del cliente:");
        //Successivamente assegno il valore letto alla variabile
        string nomeCliente = Console.ReadLine();

        Console.WriteLine($"Benvenuto {nomeCliente} nella Easy Class 3E!");

        Console.WriteLine("Inserisci il tipo di spedizione:");
        string tipoConsegna = Console.ReadLine();

        Console.WriteLine("Inserisci il numero di pacchi acquistati:");
        int numeroPacchiComprati = int.Parse(Console.ReadLine());


        int costoSpedizioneSingoloPacco = 5; // dichiarazione + assegnazione
        costoSpedizioneSingoloPacco = 10; // assegnazione


        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        //Stampa a video con concatenazione di stringhe e variabili
        // $ è il carattere speciale per l'interpolazione di stringhe
        //che permette di inserire variabili all'interno di una stringa di messaggio
        Console.WriteLine($"Il tipo di consegna selezionato è: {tipoConsegna} e il costo totale è {costoTotale}");

        // [Tipo] [nomeOggetti] = new [Tipo]();
        Enemy newEnemy = new Enemy();
    }
}