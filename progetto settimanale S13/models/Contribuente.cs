namespace progetto_settimanale_S13.models
{
    internal class Contribuente
    {
        public string _nome { get; set; }
        public string _cognome { get; set; }
        public DateTime _dataDiNascita { get; set; }
        public string _codiceFiscale { get; set; }
        public string _sesso { get; set; }
        public string _residenza { get; set; }
        public double _redditoAnnuale { get; set; }
        public double _imposta { get; set; }
        
        private void Imposta()
        {
            switch (_redditoAnnuale)
            {
                case <= 15000:
                    _imposta = (_redditoAnnuale / 100) * 23;
                    break;

                case <= 28000:
                    _imposta = (((_redditoAnnuale - 15000) / 100) * 27) + 3450;
                    break;

                case <= 55000:
                    _imposta = (((_redditoAnnuale - 28000) / 100) * 38) + 6960;
                    break;

                case <= 75000:
                    _imposta = (((_redditoAnnuale - 55000) / 100) * 41) + 17220;
                    break;

                case > 75000:
                    _imposta = (((_redditoAnnuale - 75000) / 100) * 43) + 25420;
                    break;

                default:
                    Console.WriteLine("Errore nel calcolo dell'_imposta");
                    break;
            }
        }

        public void getData()
        {
            Imposta();
            Console.WriteLine(" ");
            Console.WriteLine($"==================================================\r\n\r\nCALCOLO DELL'IMPOSTA DA VERSARE:\r\n\r\nContribuente: {_nome} {_cognome}, \r\n\r\nnato il {_dataDiNascita.ToShortDateString()} ({_sesso}), \r\n\r\nresidente in {_residenza}, \r\n\r\ncodice fiscale: {_codiceFiscale}\r\n\r\nReddito dichiarato: {_redditoAnnuale}€\r\n\r\nIMPOSTA DA VERSARE: {_imposta}€");
        }
    } 
}
