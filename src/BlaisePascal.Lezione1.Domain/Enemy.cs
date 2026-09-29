namespace BlaisePascal.Lezione1.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy
    {
        // attributo privato
        //modificatore di accesso che indica che il campoè accessibile solo all'interno della classe Enemy
        private int _health; //mutabile

        //attributo costante privato
        private const int MaxHealth = 100; //costante che rappresenta la vita massima del nemico
        // const è come il val del kotlin

        // costruttore pubblico per istanziare un oggetto Enemy con un valore di salute iniziale
        public Enemy() { }


    }
}
