using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4E_INF_DellaCostanzaEnrico_GestioneArticoli
{
    internal class Articoli
    {
        string codice;
        string unitadimisura;
        string descrizione;
        double prezzo;

        string Codice { get { return codice; } }
        string Unitadimisura { get { return unitadimisura; } }
        string Descrizione { get { return descrizione; } }
        double Prezzo { get { return prezzo; } }

        public Articoli(string codice,string unitadimisura,string descrizione,double prezzo)
        {
            this.codice = codice;
            this.unitadimisura = unitadimisura;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }




    }

}
