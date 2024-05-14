using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBrasilJSON {
    public class AlertaMonitore {
        public string existe_informacao { get; set; }
    }

    public class AlertaParticipacoes {
        public string existe_informacao { get; set; }
        public object conteudo { get; set; }
    }

    public class Celular {
        public List<Telefone> telefone { get; set; }
    }

    public class Contato {
        public string cpf { get; set; }
        public string nome { get; set; }
        public string idade { get; set; }
        public string local { get; set; }
        public string campo { get; set; }
    }

    public class ContatoPreferencial {
        public string existe_informacao { get; set; }
        public Conteudo conteudo { get; set; }
    }

    public class Content {
        public Nome nome { get; set; }
        public DadosParentes dados_parentes { get; set; }
        public PessoasContato pessoas_contato { get; set; }
        public PesquisaEnderecos pesquisa_enderecos { get; set; }
        public TrabalhaTrabalhou trabalha_trabalhou { get; set; }
        public ContatoPreferencial contato_preferencial { get; set; }
        public ResidentesMesmoDomicilio residentes_mesmo_domicilio { get; set; }
        public Emails emails { get; set; }
        public NumeroBeneficio numero_beneficio { get; set; }
        public AlertaParticipacoes alerta_participacoes { get; set; }
        public PesquisaTelefones pesquisa_telefones { get; set; }
        public AlertaMonitore alerta_monitore { get; set; }
        public OutrosDocumentos outros_documentos { get; set; }
        public string protocolo { get; set; }
        public MatrizFilial matriz_filial { get; set; }
    }

    public class Conteudo {
        public string documento { get; set; }
        public string mae { get; set; }
        public string tipo_documento { get; set; }
        public string nome { get; set; }
        public List<object> outras_grafias { get; set; }
        public string data_nascimento { get; set; }
        public List<object> outras_datas_nascimento { get; set; }
        public PessoaExpostaPublicamente pessoa_exposta_publicamente { get; set; }
        public string idade { get; set; }
        public string signo { get; set; }
        public object obito { get; set; }
        public string data_obito { get; set; }
        public string sexo { get; set; }
        public string uf { get; set; }
        public string situacao_receita { get; set; }
        public string situacao_receita_data { get; set; }
        public string situacao_receita_hora { get; set; }
        public Estrangeiro estrangeiro { get; set; }

        public List<Contato> contato { get; set; }

        public List<Endereco> endereco { get; set; }

        public List<string> email { get; set; }

        public Fixo fixo { get; set; }
        public Celular celular { get; set; }
    }

    public class DadosParentes {
        public string existe_informacao { get; set; }
        public Conteudo conteudo { get; set; }
    }

    public class Emails {
        public string existe_informacao { get; set; }
        public Conteudo conteudo { get; set; }
    }

    public class Endereco {
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }

    public class Estrangeiro {
        public string existe_informacao { get; set; }
        public string estrangeiro { get; set; }
        public PaisOrigem pais_origem { get; set; }
    }

    public class Fixo {
        public List<Telefone> telefone { get; set; }

    }

    public class MatrizFilial {
        public string existe_informacao { get; set; }
    }

    public class Nome {
        public string existe_informacao { get; set; }
        public Conteudo conteudo { get; set; }
    }

    public class NumeroBeneficio {
        public string existe_informacao { get; set; }
    }

    public class OutrosDocumentos {
        public string existe_informacao { get; set; }
        public string rg { get; set; }
    }

    public class PaisOrigem {
        public string codigo { get; set; }
        public string origem { get; set; }
    }

    public class PesquisaEnderecos {
        public string existe_informacao { get; set; }
        public Conteudo conteudo { get; set; }
    }

    public class PesquisaTelefones {
        public string existe_informacao { get; set; }
        public Conteudo conteudo { get; set; }
    }

    public class PessoaExpostaPublicamente {
        public string existe_informacao { get; set; }
        public int relacionados { get; set; }
        public string conteudo { get; set; }
    }

    public class PessoasContato {
        public string existe_informacao { get; set; }
        public List<object> conteudo { get; set; }
    }

    public class ResidentesMesmoDomicilio {
        public string existe_informacao { get; set; }
        public List<object> conteudo { get; set; }
    }

    public class Response {
        public string code { get; set; }
        public string message { get; set; }
        public string date { get; set; }
        public string hour { get; set; }
        public string revision { get; set; }
        public string server { get; set; }
        public Content content { get; set; }
    }

    public class ConsultaCPFResponse {
        public bool error { get; set; }
        public string message { get; set; }
        public Response response { get; set; }
        public int api_limit { get; set; }
        public string api_limit_for { get; set; }
        public int api_limit_used { get; set; }
    }

    public class Telefone {
        public string numero { get; set; }
        public string operadora { get; set; }
        public object data_referencia { get; set; }
        public string tipo_tel { get; set; }
        public string tem_zap { get; set; }
        public string nao_pertube { get; set; }
        public object img { get; set; }
        public string prioridade { get; set; }
    }

    public class TrabalhaTrabalhou {
        public string existe_informacao { get; set; }
        public List<object> conteudo { get; set; }
    }
}
