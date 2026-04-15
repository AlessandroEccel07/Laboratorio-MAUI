using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloList.Models
{
    internal class Frutto
    {
		private string _nome;

		public string nome
		{
			get { return _nome; }
			set { _nome = value; }
		}
		private string _provenienza;

		public string provenienza
		{
			get { return _provenienza; }
			set { _provenienza = value; }
		}

        public Frutto(string nome, string provenienza)
        {
            _nome = nome;
            _provenienza= provenienza;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return nome + ";" + provenienza;
        }
    }
}
