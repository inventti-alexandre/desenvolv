using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Projeto.VemProFut.DB.Time
{
    class TimeDTO
    {
        public int id_clubes { get; set; }
        public string nm_nomeclube { get; set; }
        public string nm_nome_mascara { get; set; }
        public long lg_logo { get; set; }
        public string ps_pais { get; set; }
        public string et_estado { get; set; }
        public string cd_cidade { get; set; }
        public string br_bairro { get; set; }
        public string ra_rua { get; set; }
        public int nr_numero { get; set; }
        public int cp_cep { get; set; }
        public string cp_complemento_endereco { get; set; }
        public string nm_estadio { get; set; }
        public int cn_cnpj { get; set; }
        public string so_site_oficial { get; set; }
        public string em_email { get; set; }
        public int tf_telefone_fixo { get; set; }
        public int tl_celular { get; set; }
        public int ac_ano_cliacao { get; set; }
        public DateTime dt_data_cadastro { get; set; }
        public string fd_fundadores { get; set; }
        public string obs_onservacoes { get; set; }
       
    }
}
