using progetto_settimanale_S13.models;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Contribuente contribuente = new Contribuente();

Console.WriteLine(" ");
Console.WriteLine("Inserisci il nome");
string nome = Console.ReadLine();
contribuente._nome = nome;


Console.WriteLine(" ");
Console.WriteLine("Inserisci il cognome");
string cognome = Console.ReadLine();
contribuente._cognome = cognome;


string dataDiNascita;
bool boolean = false;

do
{
    Console.WriteLine(" ");
    Console.WriteLine("Inserisci la data di nascita, esempio: 26/6/2003");
    dataDiNascita = Console.ReadLine();
    if (DateTime.TryParse(dataDiNascita, out DateTime dataNascita))
    {
        contribuente._dataDiNascita = dataNascita;
        boolean = true;
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Data di nascita non valida");
    }
} while (!boolean);


bool boolean2 = false;
do
{
    Console.WriteLine(" ");
    Console.WriteLine("Inserisci codice fiscale");
    string codiceFiscale = Console.ReadLine();
    if (!ControlloCF(codiceFiscale, contribuente._cognome))
    {
        Console.WriteLine("Il codice fiscale non è valido");
    }
    else
    {
        contribuente._codiceFiscale = codiceFiscale;
        boolean2 = true;
    }
}
while (!boolean2);


bool boolean3 = false;
do
{
    Console.WriteLine(" ");
    Console.WriteLine("Inserisci il tuo sesso M/F");
    string sesso = Console.ReadLine();
    if (sesso.ToUpper() == "M")
    {
        contribuente._sesso = sesso;
        boolean3 = true;
    }
    else if (sesso.ToUpper() == "F")
    {
        contribuente._sesso = sesso;
        boolean3 = true;
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Inserisci un sesso valido");
        boolean3 = false;
    }
} while (!boolean3);


bool boolean4 = false;
do
{
    Console.WriteLine(" ");
    Console.WriteLine("Inserisci comune di residenza");
    string residenza = Console.ReadLine();
    if (int.TryParse(residenza, out int result))
    {
        Console.WriteLine(" ");
        Console.WriteLine("Inserire una residenza valida");
    }
    else
    {
        contribuente._residenza = residenza;
        boolean4 = true;
    }
} while (!boolean4);


bool boolean5 = false;
do
{
    Console.WriteLine(" ");
    Console.WriteLine("Inserisci reddito annuale");
    string reddito = Console.ReadLine();
    if (double.TryParse(reddito, out double num) && num >= 0)
    {
        contribuente._redditoAnnuale = num;
        boolean5 = true;
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Inserisci un valore valido");
    }
} while (!boolean5);

bool ControlloCF(string codiceFiscale, string cognome)
{
    if (codiceFiscale.Length == 16)
    {
        string codiceAbbreviato = codiceFiscale.Substring(0, 3);
        char[] codiceChar = codiceAbbreviato.ToCharArray();
        for (int i = 0; i < codiceChar.Length; i++)
        {
            if (!cognome.ToUpper().Contains(codiceChar[i]))
            {
                return false;
            }
        }
        return true;
    }
    else
    {
        return false;
    }
}

contribuente.getData();

