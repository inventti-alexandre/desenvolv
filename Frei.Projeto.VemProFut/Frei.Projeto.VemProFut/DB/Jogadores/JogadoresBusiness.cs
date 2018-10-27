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
            JogadoresDatabase db = new JogadoresDatabase();
            return db.Salvar(dto);
        }

        public void Alterar(JogadoresDTO dto)
        {
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
