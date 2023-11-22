using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eugenio.Malenchi._4i.WPF
{
    internal class Contatto
    {
        private int _numero;
        private string _cognome;

        public int Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException();

                _numero = value;
            }
        }

        public string Nome { get; set; }
        public string EMail { get; set; }
        public string Telefono { get; set; }
        public string Citta { get; set; }
        public string CAP { get; set; }

        public string Cognome { get => _cognome; set => _cognome = value; }

        public Contatto() { }

        public Contatto(int numero, string nome, string cognome)
        {
            Numero = numero;
            Nome = nome;
            Cognome = cognome;
        }

        public Contatto (string riga)
        {

            string[] campi = riga.Split(';');
            this.Nome = campi[0];
            this.Cognome = campi[1];
            this.Telefono = campi[2];
            this.EMail = campi[3];
            this.CAP = campi[4];


        }
    }
}