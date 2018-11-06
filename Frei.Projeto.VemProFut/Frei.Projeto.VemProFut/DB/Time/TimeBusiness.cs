using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Projeto.VemProFut.DB.Time
{
    class TimeBusiness
    {
        public int Salvar(TimeDTO dto)
        {
            TimeDatabase db = new TimeDatabase();
            return db.Salvar(dto);
        }

        public void Alterar(TimeDTO dto)
        {
            TimeDatabase db = new TimeDatabase();
            db.Alterar(dto);
        }
        public void Remover(int ID)
        {
            TimeDatabase db = new TimeDatabase();
            db.Remover(ID);
        }

        public List<TimeViewDTO> Listar()
        {
            TimeDatabase db = new TimeDatabase();
            return db.Listar();
        }

        public List<TimeViewDTO> ConsultarporNome(string nome)
        {
            TimeDatabase db = new TimeDatabase();
            return db.ConsultarPorNome(nome);
        }

        public List<TimeViewDTO> ConsultarporId(int ID)
        {
            TimeDatabase db = new TimeDatabase();
            return db.ConsultarPorID(ID);
        }
    }
}
