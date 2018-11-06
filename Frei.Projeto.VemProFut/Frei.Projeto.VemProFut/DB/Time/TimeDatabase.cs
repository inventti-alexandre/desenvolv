using Frei.Projeto.VemProFut.DB.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Projeto.VemProFut.DB.Time
{
    class TimeDatabase
    {
        public int Salvar(TimeDTO dto)
        {
            string Script = @"INSERT into tb_clubes (nm_nomeclube,
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
                                                     tf_telefone_fixo,
                                                     tl_celular,
                                                     ac_ano_cliacao,
                                                     dt_data_cadastro,
                                                     fd_fundadores,
                                                     obs_onservacoes)
                                                     VALUES
                                                     (@nm_nomeclube,
                                                     @nm_nome_mascara,
                                                     @sg_sigla,
                                                     @lg_logo,
                                                     @ps_pais,
                                                     @et_estado,
                                                     @cd_cidade,
                                                     @br_bairro,
                                                     @ra_rua,
                                                     @nr_numero,
                                                     @cp_cep,
                                                     @cp_complemento_endereco,
                                                     @nm_estadio,
                                                     @cn_cnpj,
                                                     @so_site_oficial,
                                                     @em_email,
                                                     @tf_telefone_fixo,
                                                     @tl_celular,
                                                     @ac_ano_cliacao,
                                                     @dt_data_cadastro,
                                                     @fd_fundadores,
                                                     @obs_onservacoes)";



            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nomeclube", dto.nm_nomeclube));
            parms.Add(new MySqlParameter("nm_nome_mascara", dto.nm_nome_mascara));
            parms.Add(new MySqlParameter("sg_sigla", dto.nm_nome_mascara));
            parms.Add(new MySqlParameter("lg_logo", dto.lg_logo));
            parms.Add(new MySqlParameter("ps_pais", dto.ps_pais));
            parms.Add(new MySqlParameter("et_estado", dto.et_estado));
            parms.Add(new MySqlParameter("cd_cidade", dto.cd_cidade));
            parms.Add(new MySqlParameter("br_bairro", dto.br_bairro));
            parms.Add(new MySqlParameter("ra_rua", dto.ra_rua));
            parms.Add(new MySqlParameter("nr_numero", dto.nr_numero));
            parms.Add(new MySqlParameter("cp_cep", dto.cp_cep));
            parms.Add(new MySqlParameter("cp_complemento_endereco", dto.cp_complemento_endereco));
            parms.Add(new MySqlParameter("nm_estadio", dto.nm_estadio));
            parms.Add(new MySqlParameter("cn_cnpj", dto.cn_cnpj));
            parms.Add(new MySqlParameter("so_site_oficial", dto.so_site_oficial));
            parms.Add(new MySqlParameter("em_email", dto.em_email));
            parms.Add(new MySqlParameter("tf_telefone_fixo", dto.tf_telefone_fixo));
            parms.Add(new MySqlParameter("tl_celular", dto.tl_celular));
            parms.Add(new MySqlParameter("ac_ano_cliacao", dto.ac_ano_cliacao));
            parms.Add(new MySqlParameter("dt_data_cadastro", dto.dt_data_cadastro));
            parms.Add(new MySqlParameter("fd_fundadores", dto.fd_fundadores));
            parms.Add(new MySqlParameter("obs_onservacoes", dto.obs_onservacoes));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(Script, parms);

        }
        public void Alterar(TimeDTO dto)
        {
            string Script = @"UPDATE tb_clubes SET nm_nomeclube = @nm_nomeclube,
                                                     nm_nome_mascara = @nm_nome_mascara,
                                                     sg_sigla = @sg_sigla,
                                                     lg_logo = @lg_logo,
                                                     ps_pais = @ps_pais,
                                                     et_estado = @et_estado,
                                                     cd_cidade = @cd_cidade,
                                                     br_bairro = @br_bairro,
                                                     ra_rua = @ra_rua,
                                                     nr_numero = @nr_numero,
                                                     cp_cep = @cp_cep,
                                                     cp_complemento_endereco = @cp_complemento_endereco,
                                                     nm_estadio = @nm_estadio,
                                                     cn_cnpj = @cn_cnpj,
                                                     so_site_oficial = @so_site_oficial,
                                                     em_email = @em_email,
                                                     tf_telefone_fixo = @tf_telefone_fixo,
                                                     tl_celular = @tl_celular,
                                                     ac_ano_cliacao = @ac_ano_cliacao,
                                                     dt_data_cadastro = @dt_data_cadastro,
                                                     fd_fundadores = @fd_fundadores,
                                                     obs_onservacoes = @obs_onservacoes
                                              WHERE  id_clubes = @id_clubes";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_clubes", dto.id_clubes));
            parms.Add(new MySqlParameter("nm_nomeclube", dto.nm_nomeclube));
            parms.Add(new MySqlParameter("nm_nome_mascara", dto.nm_nome_mascara));
            parms.Add(new MySqlParameter("sg_sigla", dto.nm_nome_mascara));
            parms.Add(new MySqlParameter("lg_logo", dto.lg_logo));
            parms.Add(new MySqlParameter("ps_pais", dto.ps_pais));
            parms.Add(new MySqlParameter("et_estado", dto.et_estado));
            parms.Add(new MySqlParameter("cd_cidade", dto.cd_cidade));
            parms.Add(new MySqlParameter("br_bairro", dto.br_bairro));
            parms.Add(new MySqlParameter("ra_rua", dto.ra_rua));
            parms.Add(new MySqlParameter("nr_numero", dto.nr_numero));
            parms.Add(new MySqlParameter("cp_cep", dto.cp_cep));
            parms.Add(new MySqlParameter("cp_complemento_endereco", dto.cp_complemento_endereco));
            parms.Add(new MySqlParameter("nm_estadio", dto.nm_estadio));
            parms.Add(new MySqlParameter("cn_cnpj", dto.cn_cnpj));
            parms.Add(new MySqlParameter("so_site_oficial", dto.so_site_oficial));
            parms.Add(new MySqlParameter("em_email", dto.em_email));
            parms.Add(new MySqlParameter("tf_telefone_fixo", dto.tf_telefone_fixo));
            parms.Add(new MySqlParameter("tl_celular", dto.tl_celular));
            parms.Add(new MySqlParameter("ac_ano_cliacao", dto.ac_ano_cliacao));
            parms.Add(new MySqlParameter("dt_data_cadastro", dto.dt_data_cadastro));
            parms.Add(new MySqlParameter("fd_fundadores", dto.fd_fundadores));
            parms.Add(new MySqlParameter("obs_onservacoes", dto.obs_onservacoes));

            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);


        }
        public void Remover(int id)
        {
            string Script = @"DELETE FROM tb_clubes WHERE id_clubes = @id_clubes";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_clubes", id));
            Database db = new Database();
            db.ExecuteInsertScript(Script, parms);
        }
        public List<TimeViewDTO> Listar()
        {

            string Script = @"select * from tb_jogador";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<TimeViewDTO> lista = new List<TimeViewDTO>();
            while (reader.Read())
            {
                TimeViewDTO dto = new TimeViewDTO();

                dto.id_clubes = reader.GetInt32("id_clubes");
                dto.ac_ano_cliacao = reader.GetInt32("ac_ano_cliacao");
                dto.br_bairro = reader.GetString("br_bairro");
                dto.cd_cidade = reader.GetString("cd_cidade");
                dto.cn_cnpj = reader.GetInt32("cn_cnpj");
                dto.cp_cep = reader.GetInt32("cp_cep");
                dto.cp_complemento_endereco = reader.GetString("cp_complemento_endereco");
                dto.dt_data_cadastro = reader.GetDateTime("dt_data_cadastro");
                dto.em_email = reader.GetString("em_email");
                dto.et_estado = reader.GetString("et_estado");
                dto.fd_fundadores = reader.GetInt32("fd_fundadores");
                dto.lg_logo = reader.GetString("lg_logo");
                dto.nm_estadio = reader.GetString("nm_estadio");
                dto.nm_nomeclube = reader.GetString("nm_nomeclube");
                dto.nm_nome_mascara = reader.GetString("nm_nome_mascara");
                dto.nr_numero = reader.GetInt32("nr_numero");
                dto.obs_onservacoes = reader.GetString("obs_onservacoes");
                dto.ps_pais = reader.GetString("ps_pais");
                dto.ra_rua = reader.GetString("ra_rua");
                dto.so_site_oficial = reader.GetString("so_site_oficial");
                dto.tf_telefone_fixo = reader.GetInt32("tf_telefone_fixo");
                dto.tl_celular = reader.GetInt32("tl_celular");

                lista.Add(dto);
            }
            return lista;
        }
        public List<TimeViewDTO> ConsultarPorID(int id)
        {

            string Script = @"select * from tb_jogador WHERE id_clubes LIKE @id_clubes  ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_clubes", id + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<TimeViewDTO> lista = new List<TimeViewDTO>();
            while (reader.Read())
            {
                TimeViewDTO dto = new TimeViewDTO();

                dto.id_clubes = reader.GetInt32("id_clubes");
                dto.ac_ano_cliacao = reader.GetInt32("ac_ano_cliacao");
                dto.br_bairro = reader.GetString("br_bairro");
                dto.cd_cidade = reader.GetString("cd_cidade");
                dto.cn_cnpj = reader.GetInt32("cn_cnpj");
                dto.cp_cep = reader.GetInt32("cp_cep");
                dto.cp_complemento_endereco = reader.GetString("cp_complemento_endereco");
                dto.dt_data_cadastro = reader.GetDateTime("dt_data_cadastro");
                dto.em_email = reader.GetString("em_email");
                dto.et_estado = reader.GetString("et_estado");
                dto.fd_fundadores = reader.GetInt32("fd_fundadores");
                dto.lg_logo = reader.GetString("lg_logo");
                dto.nm_estadio = reader.GetString("nm_estadio");
                dto.nm_nomeclube = reader.GetString("nm_nomeclube");
                dto.nm_nome_mascara = reader.GetString("nm_nome_mascara");
                dto.nr_numero = reader.GetInt32("nr_numero");
                dto.obs_onservacoes = reader.GetString("obs_onservacoes");
                dto.ps_pais = reader.GetString("ps_pais");
                dto.ra_rua = reader.GetString("ra_rua");
                dto.so_site_oficial = reader.GetString("so_site_oficial");
                dto.tf_telefone_fixo = reader.GetInt32("tf_telefone_fixo");
                dto.tl_celular = reader.GetInt32("tl_celular");

                lista.Add(dto);
            }
            return lista;
        }
        public List<TimeViewDTO> ConsultarPorNome(string Nome)
        {

            string Script = @"select * from Consultar_jogador_e_Clube WHERE nm_nomeclube LIKE @nm_nomeclube  ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nomeclube", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(Script, parms);
            List<TimeViewDTO> lista = new List<TimeViewDTO>();
            while (reader.Read())
            {
                TimeViewDTO dto = new TimeViewDTO();

                dto.id_clubes = reader.GetInt32("id_clubes");
                dto.ac_ano_cliacao = reader.GetInt32("ac_ano_cliacao");
                dto.br_bairro = reader.GetString("br_bairro");
                dto.cd_cidade = reader.GetString("cd_cidade");
                dto.cn_cnpj = reader.GetInt32("cn_cnpj");
                dto.cp_cep = reader.GetInt32("cp_cep");
                dto.cp_complemento_endereco = reader.GetString("cp_complemento_endereco");
                dto.dt_data_cadastro = reader.GetDateTime("dt_data_cadastro");
                dto.em_email = reader.GetString("em_email");
                dto.et_estado = reader.GetString("et_estado");
                dto.fd_fundadores = reader.GetInt32("fd_fundadores");
                dto.lg_logo = reader.GetString("lg_logo");
                dto.nm_estadio = reader.GetString("nm_estadio");
                dto.nm_nomeclube = reader.GetString("nm_nomeclube");
                dto.nm_nome_mascara = reader.GetString("nm_nome_mascara");
                dto.nr_numero = reader.GetInt32("nr_numero");
                dto.obs_onservacoes = reader.GetString("obs_onservacoes");
                dto.ps_pais = reader.GetString("ps_pais");
                dto.ra_rua = reader.GetString("ra_rua");
                dto.so_site_oficial = reader.GetString("so_site_oficial");
                dto.tf_telefone_fixo = reader.GetInt32("tf_telefone_fixo");
                dto.tl_celular = reader.GetInt32("tl_celular");

                lista.Add(dto);
            }
            return lista;
        }
        public void Alterar(TimeDTO dto)
        {
            string Script = @"tb_clubes SET"
        }
    }
}

