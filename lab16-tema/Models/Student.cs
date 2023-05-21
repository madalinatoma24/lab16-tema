using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16_tema.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public decimal Varsta { get; set; }
        public Specializari Specializare { get; set; }
        public override string ToString()
        {
            return $"id: {Id}, Nume: {Nume}, Prenume: {Prenume}, Varsta:{Varsta}, Specializare: {Specializare}";
        }
    }
}
