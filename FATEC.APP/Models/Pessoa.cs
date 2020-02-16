using System;
using System.Collections.Generic;
using System.Text;

namespace FATEC.APP.Models
{
    public class Pessoa : EntidadeDominio
    {
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
    }
}
