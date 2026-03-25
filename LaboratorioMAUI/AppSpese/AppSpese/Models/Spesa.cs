using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSpese.Models
{
    internal class Spesa
    {
        private string _descrizione;
        private string _importo;
        private string _quantita;

        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        public string Importo
        {
            get { return _importo; }
            set { _importo = value; }
        }
        public string Quantita
        {
            get { return _quantita; }
            set { _quantita = value; }
        }

        public string DaOggettoARiga()
        {
            return this.Descrizione + ";" + this.Importo + ";" + this.Quantita;
        }

        public static Spesa DaRigaAOggetto(string riga)
        {
            string[] parte = riga.Split(";");
            if (parte.Length > 3)
            {
                return null;
            }

            Spesa nuovaSpesa = new Spesa();
            nuovaSpesa.Descrizione = parte[0];
            nuovaSpesa.Importo = parte[1];
            nuovaSpesa.Quantita = parte[2];
            return nuovaSpesa;

        }
    }
}
