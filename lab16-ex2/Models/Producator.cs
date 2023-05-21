using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16_ex2.Models
{
    internal class Producator
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Nume: {Nume}, Adresa: {Adresa}";
        }
    }
}
