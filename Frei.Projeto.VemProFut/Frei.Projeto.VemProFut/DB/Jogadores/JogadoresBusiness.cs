using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Projeto.VemProFut.DB.Jogadores
{
    class JogadoresBusiness
    {
        public int Salvar (JogadoresDTO dto)
        {
            if (dto.Altura == 0)
                throw new ArgumentException("Campo altura não pode ser nulo.");

            if (dto.Apelido == string.Empty)
                throw new ArgumentException("Campo Apelido não pode estar vázio.");

            if (dto.Bairro == string.Empty)
                throw new ArgumentException("Campo Bairro não pode estar vázio.");

            if (dto.Celular == string.Empty)
                throw new ArgumentException("Campo Celular não pode estar vázio.");

            if (dto.CEP == string.Empty)
                throw new ArgumentException("Campo CEP não pode estar vázio.");

            if (dto.Cidade == string.Empty)
                throw new ArgumentException("Campo Cidade não pode estar vázio.");

            if (dto.Complementoendereco == string.Empty)
                throw new ArgumentException("Campo Complementoendereco não pode estar vázio.");

            if (dto.Cor == string.Empty)
                throw new ArgumentException("Campo Cor não pode estar vázio.");

            if (dto.CPF == string.Empty)
                throw new ArgumentException("Campo CPF não pode estar vázio.");

            if (dto.Email == string.Empty)
                throw new ArgumentException("Campo Email não pode estar vázio.");

            if (dto.EstadoUf == string.Empty)
                throw new ArgumentException("Campo EstadoUf não pode estar vázio.");

            if (dto.Foto == string.Empty)
                throw new ArgumentException("Campo Foto não pode estar vázio.");

            if (dto.Idade == 0)
                throw new ArgumentException("Campo Idade não pode estar vázio.");

            if (dto.Nacionalidade == string.Empty)
                throw new ArgumentException("Campo Nacionalidade não pode estar vázio.");

            if (dto.Nome == string.Empty)
                throw new ArgumentException("Campo Nome não pode estar vázio.");

            if (dto.Pais == string.Empty)
                throw new ArgumentException("Campo Pais não pode estar vázio.");

            if (dto.NumeroCasa == string.Empty)
                throw new ArgumentException("Campo NumeroCasa não pode estar vázio.");

            if (dto.Observacoes == string.Empty)
                throw new ArgumentException("Campo Observacoes não pode estar vázio.");

            JogadoresDatabase db = new JogadoresDatabase();
            return db.Salvar(dto);
        }

        public void Alterar(JogadoresDTO dto)
        {
            if (dto.Altura == 0)
                throw new ArgumentException("Campo altura não pode ser nulo.");

            if (dto.Apelido == string.Empty)
                throw new ArgumentException("Campo Apelido não pode estar vázio.");

            if (dto.Bairro == string.Empty)
                throw new ArgumentException("Campo Bairro não pode estar vázio.");

            if (dto.Celular == string.Empty)
                throw new ArgumentException("Campo Celular não pode estar vázio.");

            if (dto.CEP == string.Empty)
                throw new ArgumentException("Campo CEP não pode estar vázio.");

            if (dto.Cidade == string.Empty)
                throw new ArgumentException("Campo Cidade não pode estar vázio.");

            if (dto.Complementoendereco == string.Empty)
                throw new ArgumentException("Campo Complementoendereco não pode estar vázio.");

            if (dto.Cor == string.Empty)
                throw new ArgumentException("Campo Cor não pode estar vázio.");

            if (dto.CPF == string.Empty)
                throw new ArgumentException("Campo CPF não pode estar vázio.");

            if (dto.Email == string.Empty)
                throw new ArgumentException("Campo Email não pode estar vázio.");

            if (dto.EstadoUf == string.Empty)
                throw new ArgumentException("Campo EstadoUf não pode estar vázio.");

            if (dto.Foto == string.Empty)
                throw new ArgumentException("Campo Foto não pode estar vázio.");

            if (dto.Idade == 0)
                throw new ArgumentException("Campo Idade não pode estar vázio.");

            if (dto.Nacionalidade == string.Empty)
                throw new ArgumentException("Campo Nacionalidade não pode estar vázio.");

            if (dto.Nome == string.Empty)
                throw new ArgumentException("Campo Nome não pode estar vázio.");

            if (dto.Pais == string.Empty)
                throw new ArgumentException("Campo Pais não pode estar vázio.");

            if (dto.NumeroCasa == string.Empty)
                throw new ArgumentException("Campo NumeroCasa não pode estar vázio.");

            if (dto.Observacoes == string.Empty)
                throw new ArgumentException("Campo Observacoes não pode estar vázio.");

            JogadoresDatabase db = new JogadoresDatabase();
            db.Alterar(dto);
        }
        public void Remover(int ID)
        {
            JogadoresDatabase db = new JogadoresDatabase();
            db.Remover(ID);
        }

        public List<JogadoresViewDTO> Listar()
        {
            JogadoresDatabase db = new JogadoresDatabase();
            return db.Listar();
        }

        public List<JogadoresViewDTO> ConsultarporNome(string nome)
        {
            JogadoresDatabase db = new JogadoresDatabase();
            return db.ConsultarporNome(nome);
        }

        public List<JogadoresDTO> ConsultarpoId(int ID)
        {
            JogadoresDatabase db = new JogadoresDatabase();
            return db.ConsultarporId(ID);
        }
    }
}
