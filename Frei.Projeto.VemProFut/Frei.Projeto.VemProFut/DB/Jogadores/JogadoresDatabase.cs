using Frei.Projeto.VemProFut.DB.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Projeto.VemProFut.DB.Jogadores
{
    class JogadoresDatabase
    {
        public int Salvar(JogadoresDTO dto)
        {
            string script = @"insert into tb_jogador(   nm_nome,
                                                        dd_idade,
                                                        nc_nacionalidade,
                                                        ft_foto,
                                                        cr_cor,
                                                        nr_numero_camisa,
                                                        ps_posicao,
                                                        ps_peso,
                                                        at_altura,
                                                        ps_pais,
                                                        et_estado,
                                                        cd_cidade,
                                                        br_bairro,
                                                        ra_rua,
                                                        nr_numero_casa,
                                                        cp_cep,
                                                        cp_complemento_endereco,
                                                        tl_telefone_fixo,
                                                        tl_celular,
                                                        em_email,
                                                        rg,
                                                        cpf,
                                                        dt_data_nascimento,
                                                        dt_data_cadastro,
                                                        ap_apelido,
                                                        obs_observacoes,
                                                        fk_id_clube)
                                              values
                                                       (@nm_nome,
                                                        @dd_idade,
                                                        @nc_nacionalidade,
                                                        @ft_foto,
                                                        @cr_cor,
                                                        @nr_numero_camisa,
                                                        @ps_posicao,
                                                        @ps_peso,
                                                        @at_altura,
                                                        @ps_pais,
                                                        @et_estado,
                                                        @cd_cidade,
                                                        @br_bairro,
                                                        @ra_rua,
                                                        @nr_numero_casa,
                                                        @cp_cep,
                                                        @cp_complemento_endereco,
                                                        @tl_telefone_fixo,
                                                        @tl_celular,
                                                        @em_email,
                                                        @rg,
                                                        @cpf,
                                                        @dt_data_nascimento,
                                                        @dt_data_cadastro,
                                                        @ap_apelido,
                                                        @obs_observacoes,
                                                        @fk_id_clube)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("dd_idade", dto.Idade));
            parms.Add(new MySqlParameter("nc_nacionalidade", dto.Nacionalidade));
            parms.Add(new MySqlParameter("ft_foto", dto.Foto));
            parms.Add(new MySqlParameter("cr_cor", dto.Cor));
            parms.Add(new MySqlParameter("nr_numero_camisa", dto.NumeroCamisa));
            parms.Add(new MySqlParameter("ps_posicao", dto.Posicao));
            parms.Add(new MySqlParameter("ps_peso", dto.Peso));
            parms.Add(new MySqlParameter("at_altura", dto.Altura));
            parms.Add(new MySqlParameter("ps_pais", dto.Pais));
            parms.Add(new MySqlParameter("et_estado", dto.EstadoUf));
            parms.Add(new MySqlParameter("cd_cidade", dto.Cidade));
            parms.Add(new MySqlParameter("br_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ra_rua", dto.Rua));
            parms.Add(new MySqlParameter("nr_numero_casa", dto.NumeroCasa));
            parms.Add(new MySqlParameter("cp_cep", dto.CEP));
            parms.Add(new MySqlParameter("cp_complemento_endereco", dto.Complementoendereco));
            parms.Add(new MySqlParameter("tl_telefone_fixo", dto.TelefoneFixo));
            parms.Add(new MySqlParameter("tl_celular", dto.Celular));
            parms.Add(new MySqlParameter("em_email", dto.Email));
            parms.Add(new MySqlParameter("rg", dto.RG));
            parms.Add(new MySqlParameter("cpf", dto.CPF));
            parms.Add(new MySqlParameter("dt_data_nascimento", dto.DataNascimento));
            parms.Add(new MySqlParameter("dt_data_cadastro", dto.DataCadastro));
            parms.Add(new MySqlParameter("ap_apelido", dto.Apelido));
            parms.Add(new MySqlParameter("obs_observacoes", dto.Observacoes));
            parms.Add(new MySqlParameter("fk_id_clube", dto.FKClube));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void Alterar (JogadoresDTO dto)
        {
            string script = @"update tb_jogador set
                                                        nm_nome=@nm_nome,
                                                        dd_idade=@dd_idade,
                                                        nc_nacionalidade=@nc_nacionalidade,
                                                        ft_foto=@ft_foto,
                                                        cr_cor=@cr_cor,
                                                        nr_numero_camisa=@nr_numero_camisa,
                                                        ps_posicao=@ps_posicao,
                                                        ps_peso=@ps_peso,
                                                        at_altura=@at_altura,
                                                        ps_pais=@ps_pais,
                                                        et_estado=@et_estado,
                                                        cd_cidade=@cd_cidade,
                                                        br_bairro=@br_bairro,
                                                        ra_rua=@ra_rua,
                                                        nr_numero_casa=@nr_numero_casa,
                                                        cp_cep=@cp_cep,
                                                        cp_complemento_endereco=@cp_complemento_endereco,
                                                        tl_telefone_fixo=@tl_telefone_fixo,
                                                        tl_celular=@tl_celular,
                                                        em_email=@em_email,
                                                        rg=@rg,
                                                        cpf=@cpf,
                                                        dt_data_nascimento=@dt_data_nascimento,
                                                        dt_data_cadastro=@dt_data_cadastro,
                                                        ap_apelido=@ap_apelido,
                                                        obs_observacoes=@obs_observacoes,
                                                        fk_id_clube=@fk_id_clube
                                      where             id_jogador=@id_jogador";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_jogador", dto.Idjogador));
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("dd_idade", dto.Idade));
            parms.Add(new MySqlParameter("nc_nacionalidade", dto.Nacionalidade));
            parms.Add(new MySqlParameter("ft_foto", dto.Foto));
            parms.Add(new MySqlParameter("cr_cor", dto.Cor));
            parms.Add(new MySqlParameter("nr_numero_camisa", dto.NumeroCamisa));
            parms.Add(new MySqlParameter("ps_posicao", dto.Posicao));
            parms.Add(new MySqlParameter("ps_peso", dto.Peso));
            parms.Add(new MySqlParameter("at_altura", dto.Altura));
            parms.Add(new MySqlParameter("ps_pais", dto.Pais));
            parms.Add(new MySqlParameter("et_estado", dto.EstadoUf));
            parms.Add(new MySqlParameter("cd_cidade", dto.Cidade));
            parms.Add(new MySqlParameter("br_bairro", dto.Bairro));
            parms.Add(new MySqlParameter("ra_rua", dto.Rua));
            parms.Add(new MySqlParameter("nr_numero_casa", dto.NumeroCasa));
            parms.Add(new MySqlParameter("cp_cep", dto.CEP));
            parms.Add(new MySqlParameter("cp_complemento_endereco", dto.Complementoendereco));
            parms.Add(new MySqlParameter("tl_telefone_fixo", dto.TelefoneFixo));
            parms.Add(new MySqlParameter("tl_celular", dto.Celular));
            parms.Add(new MySqlParameter("em_email", dto.Email));
            parms.Add(new MySqlParameter("rg", dto.RG));
            parms.Add(new MySqlParameter("cpf", dto.CPF));
            parms.Add(new MySqlParameter("dt_data_nascimento", dto.DataNascimento));
            parms.Add(new MySqlParameter("dt_data_cadastro", dto.DataCadastro));
            parms.Add(new MySqlParameter("ap_apelido", dto.Apelido));
            parms.Add(new MySqlParameter("obs_observacoes", dto.Observacoes));
            parms.Add(new MySqlParameter("fk_id_clube", dto.FKClube));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover(int Id)
        {
            string script = @"delete from tb_jogador where id_jogador=@id_jogador";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_jogador", Id));
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<JogadoresViewDTO> Listar()
        {
            string script = @"select * from tb_jogador";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<JogadoresViewDTO> lista = new List<JogadoresViewDTO>();
            while(reader.Read())
            {
                JogadoresViewDTO dto = new JogadoresViewDTO();
                dto.Idjogador= reader.GetInt32("id_jogador");
                dto.Nome = reader.GetString("nm_nome");
                dto.Idade = reader.GetInt32("dd_idade");
                dto.Nacionalidade= reader.GetString("nc_nacionalidade");
                dto.Foto=reader.GetString("ft_foto");
                dto.Cor=reader.GetString("cr_cor");
                dto.NumeroCamisa = reader.GetInt32("nr_numero_camisa");
                dto.Posicao= reader.GetString("ps_posicao");
                dto.Peso = reader.GetDecimal("ps_peso");
                dto.Altura = reader.GetDecimal("at_altura");
                dto.Pais= reader.GetString("ps_pais");
                dto.EstadoUf= reader.GetString("et_estado");
                dto.Cidade = reader.GetString("cd_cidade");
                dto.Bairro= reader.GetString("br_bairro");
                dto.Rua= reader.GetString("ra_rua");
                dto.NumeroCasa= reader.GetString("nr_numero_casa");
                dto.CEP= reader.GetString("cp_cep");
                dto.Complementoendereco= reader.GetString("cp_complemento_endereco");
                dto.TelefoneFixo= reader.GetString("tl_telefone_fixo");
                dto.Celular= reader.GetString("tl_celular");
                dto.Email= reader.GetString("em_email");
                dto.RG= reader.GetString("rg");
                dto.CPF= reader.GetString("cpf");
                dto.DataNascimento = reader.GetDateTime("dt_data_nascimento");
                dto.DataCadastro= reader.GetDateTime("dt_data_cadastro");
                dto.Apelido = reader.GetString("ap_apelido");
                dto.Observacoes= reader.GetString("obs_observacoes");
                dto.IDClube = reader.GetInt32("id_clubes");
                dto.NomeClube = reader.GetString("nm_nomeclube");

                lista.Add(dto);
            }
            return lista;
        }

        public List<JogadoresViewDTO> ConsultarporNome(string Nome)
        {
            string script = @"select * from Consultar_jogador_e_Clube where nm_nome like @nm_nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", Nome + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<JogadoresViewDTO> lista = new List<JogadoresViewDTO>();
            while (reader.Read())
            {
                JogadoresViewDTO dto = new JogadoresViewDTO();
                dto.Idjogador = reader.GetInt32("id_jogador");
                dto.Nome = reader.GetString("nm_nome");
                dto.Idade = reader.GetInt32("dd_idade");
                dto.Nacionalidade = reader.GetString("nc_nacionalidade");
                dto.Foto = reader.GetString("ft_foto");
                dto.Cor = reader.GetString("cr_cor");
                dto.NumeroCamisa = reader.GetInt32("nr_numero_camisa");
                dto.Posicao = reader.GetString("ps_posicao");
                dto.Peso = reader.GetDecimal("ps_peso");
                dto.Altura = reader.GetDecimal("at_altura");
                dto.Pais = reader.GetString("ps_pais");
                dto.EstadoUf = reader.GetString("et_estado");
                dto.Cidade = reader.GetString("cd_cidade");
                dto.Bairro = reader.GetString("br_bairro");
                dto.Rua = reader.GetString("ra_rua");
                dto.NumeroCasa = reader.GetString("nr_numero_casa");
                dto.CEP = reader.GetString("cp_cep");
                dto.Complementoendereco = reader.GetString("cp_complemento_endereco");
                dto.TelefoneFixo = reader.GetString("tl_telefone_fixo");
                dto.Celular = reader.GetString("tl_celular");
                dto.Email = reader.GetString("em_email");
                dto.RG = reader.GetString("rg");
                dto.CPF = reader.GetString("cpf");
                dto.DataNascimento = reader.GetDateTime("dt_data_nascimento");
                dto.DataCadastro = reader.GetDateTime("dt_data_cadastro");
                dto.Apelido = reader.GetString("ap_apelido");
                dto.Observacoes = reader.GetString("obs_observacoes");
                dto.IDClube = reader.GetInt32("id_clubes");
                dto.NomeClube=reader.GetString("nm_nomeclube");

                lista.Add(dto);
            }
            return lista;
        }

        public List<JogadoresDTO> ConsultarporId(int ID)
        {
            string script = @"select * from tb_jogador where id_jogador like @id_jogador";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_jogador", ID + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<JogadoresDTO> lista = new List<JogadoresDTO>();
            while (reader.Read())
            {
                JogadoresDTO dto = new JogadoresDTO();
                dto.Idjogador = reader.GetInt32("id_jogador");
                dto.Nome = reader.GetString("nm_nome");
                dto.Idade = reader.GetInt32("dd_idade");
                dto.Nacionalidade = reader.GetString("nc_nacionalidade");
                dto.Foto = reader.GetString("ft_foto");
                dto.Cor = reader.GetString("cr_cor");
                dto.NumeroCamisa = reader.GetInt32("nr_numero_camisa");
                dto.Posicao = reader.GetString("ps_posicao");
                dto.Peso = reader.GetDecimal("ps_peso");
                dto.Altura = reader.GetDecimal("at_altura");
                dto.Pais = reader.GetString("ps_pais");
                dto.Cidade = reader.GetString("cd_cidade");
                dto.EstadoUf = reader.GetString("et_estado");
                dto.Bairro = reader.GetString("br_bairro");
                dto.Rua = reader.GetString("ra_rua");
                dto.NumeroCasa = reader.GetString("nr_numero_casa");
                dto.CEP = reader.GetString("cp_cep");
                dto.Complementoendereco = reader.GetString("cp_complemento_endereco");
                dto.TelefoneFixo = reader.GetString("tl_telefone_fixo");
                dto.Celular = reader.GetString("tl_celular");
                dto.Email = reader.GetString("em_email");
                dto.RG = reader.GetString("rg");
                dto.CPF = reader.GetString("cpf");
                dto.DataNascimento = reader.GetDateTime("dt_data_nascimento");
                dto.DataCadastro = reader.GetDateTime("dt_data_cadastro");
                dto.Apelido = reader.GetString("ap_apelido");
                dto.Observacoes = reader.GetString("obs_observacoes");
                dto.FKClube = reader.GetInt32("fk_id_clube");

                lista.Add(dto);
            }
            return lista;
        }
        
    }
}
