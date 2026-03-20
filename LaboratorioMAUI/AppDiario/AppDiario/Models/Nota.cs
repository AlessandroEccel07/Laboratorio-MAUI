
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppDiario.Models
{
    internal class Nota
    {
		private string _titolo;

		public string Titolo
		{
			get { return _titolo; }
			set {
				if (String.IsNullOrEmpty(value))
				{ 
				value = "Sconosciuto"; 
				}
				_titolo = value;
			}
		}
		private string _testo;

		public string Testo
		{
			get { return _testo; }
			set { _testo = value; }
		}
        public string DaRigaAOggetto() 
		{
			return this.Titolo + ";" + this.Testo;
		}

        public static Nota DaRigaAOggetto(string riga)
		{
			string[] parti = riga.Split(";");
			if(parti.Length < 2 )
			{
				return null;
			}
			Nota nuovaNota = new Nota();
			nuovaNota.Titolo = parti[0];
			nuovaNota.Testo = parti[1];
			return nuovaNota;
		}
		
	}
}
