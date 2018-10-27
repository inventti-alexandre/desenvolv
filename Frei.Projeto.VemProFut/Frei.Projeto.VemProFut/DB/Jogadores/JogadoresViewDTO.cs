using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Projeto.VemProFut.DB.Jogadores
{
    class JogadoresViewDTO
    {
        public int Idjogador { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Nacionalidade { get; set; }
        public string Foto { get; set; }
        public string Cor { get; set; }
        public int NumeroCamisa { get; set; }
        public string Posicao { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public string EstadoUf { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string NumeroCasa { get; set; }
        public string CEP { get; set; }
        public string Complementoendereco { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Apelido { get; set; }
        public string Observacoes { get; set; }
        public int IDClube { get; set; }
        public string NomeClube { get; set; }
    }
}
