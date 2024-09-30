using ClucerescuGestioneBiblioteca;

Console.WriteLine("Gestione biblioteca");

Console.WriteLine("Inserimento libri");

Libro[] biblioteca = new Libro[500];
int indice = 0;

bool continua = true;
while (continua)
{

    // Sintassi creazione di un oggetto da una classe
    Libro oggettoLibro = new Libro();

    Console.WriteLine("Inserisci il titolo");
    oggettoLibro.Titolo = Console.ReadLine();
    Console.WriteLine("Inserisci l'autore");
    oggettoLibro.Autore = Console.ReadLine();
    Console.WriteLine("Inserisci il numero di pagine: ");
    oggettoLibro.Pagine = int.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci il prezzo :");
    oggettoLibro.Prezzo = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Il prezzo in dollari sarà : " + oggettoLibro.PrezzoInDollari);

    biblioteca[indice] = oggettoLibro;
    indice++;

    Console.WriteLine("Vuoi inserire un altro libro (S/N)? ");
    string risposta = Console.ReadLine();
    if (risposta == "N") continua = false;

}
