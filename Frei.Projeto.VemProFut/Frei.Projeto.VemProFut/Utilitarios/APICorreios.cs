using Correios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Projeto.VemProFut.Utilitarios
{
    class APICorreios
    {
        public CorreiosDTO CEPDADOS(string CEP)
        {
            CorreiosApi service = new CorreiosApi();
            CorreiosDTO dto = new CorreiosDTO();
            var cep = service.consultaCEP(CEP);
            dto.UF = cep.uf;
            dto.Cidade = cep.cidade;
            dto.Bairro = cep.bairro;
            dto.Rua = cep.end;
            return dto;

        }
        }
    }
