public class Program
{ 
    public static void Main()
    {
        Console.WriteLine("Benvenuto nella libreria Easy Class 3E!");

        int costoSpedizioneSingoloPacco = 5; // dichiarazione + assegnazione
        costoSpedizioneSingoloPacco = 10; // assegnazione

        int numeroPacchiComprati = 2;

        string tipoConsegna = "Standard"; // dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        //Stampa a video con concatenazione di stringhe e variabili
        // $ è il carattere speciale per l'interpolazione di stringhe
        //che permette di inserire variabili all'interno di una stringa di messaggio
        Console.WriteLine($"Il tipo di consegna selezionato è: {tipoConsegna} e il costo totale è {costoTotale}");


    }
}