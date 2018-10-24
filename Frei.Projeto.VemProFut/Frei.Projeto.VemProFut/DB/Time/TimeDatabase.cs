using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Projeto.VemProFut.DB.Time
{
    class TimeDatabase
    {
        public int SalvarTimes (TimeDTO dto)
        {
            string script = @"INSERT into tb_clubes(tb_clubes,
                                                     nm_nome_mascara,
                                                     sg_sigla,
                                                     lg_logo,
                                                     ps_pais,
                                                     et_estado,
                                                     cd_cidade,
                                                     br_bairro,
                                                     ra_rua,
                                                     nr_numero,
                                                     cp_cep,
                                                     cp_complemento_endereco,
                                                     nm_estadio,
                                                     cn_cnpj,
                                                     so_site_oficial,
                                                     em_email,
                                                     "
        }
    }
}
