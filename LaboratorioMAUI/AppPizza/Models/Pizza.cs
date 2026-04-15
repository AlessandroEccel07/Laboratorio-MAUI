using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPizza.Models
{
    internal class Pizza
    {
        private string _nome;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private float _prezzo;

        public float prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        private String _image;

        public String image
        {
            get { return _image; }
            set { _image = value; }
        }

        private String _ingredienti;

        public String ingredienti
        {
            get { return _ingredienti; }
            set { _ingredienti = value; }
        }



        public Pizza(string nome, float prezzo)
        {
            _nome = nome;
            _prezzo = prezzo;
            _image = image;
            _ingredienti = ingredienti;
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
            return image +" "+  nome + ";" + prezzo +" "+ ingredienti ;
        }
    }
}   
