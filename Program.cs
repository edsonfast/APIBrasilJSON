// See https://aka.ms/new-console-template for more information
using APIBrasilJSON;
using System.Text;

var Clt = new ConsultaCPF();

// Retorno Telefone como Lista []
await Clt.Consulta("03531087908");

// Retorno Telefone como com Obj {}
await Clt.Consulta("7729175908");


public class ConsultaCPF() {

    public ConsultaCPFResponse ConsultaCPFResponseResult { get; set; }

    public async Task Consulta(string _cpf) {
        using (var client = new System.Net.Http.HttpClient()) {

            string apiv2 = "https://gateway.apibrasil.io";
            string token = "XXX";

            string url = apiv2 + "/api/v2/dados/cpf";

            client.DefaultRequestHeaders.Add("DeviceToken", "XXX");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            string RequestStr = Newtonsoft.Json.JsonConvert.SerializeObject(new CPFRequest() { cpf = _cpf });

            var response = await client.PostAsync(url, new System.Net.Http.StringContent(RequestStr, Encoding.UTF8, "application/json"));

            if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                var json = await response.Content.ReadAsStringAsync();

                // Exemplo: O JSON "Telefone" da API está retornando como
                // obj simples {} quando tem um só registro e
                // como lista [] quanto tem mais de um registro gerando o erro:

                // Cannot deserialize the current JSON object (e.g. {"name":"value"}) into type 'System.Collections.Generic.List`1[APIBrasilJSON.Telefone]' because the type requires a JSON array (e.g. [1,2,3]) to deserialize correctly.
                // To fix this error either change the JSON to a JSON array(e.g. [1, 2, 3]) or change the deserialized type so that it is a normal .NET type(e.g.not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object.JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object.
                // Path 'response.content.pesquisa_telefones.conteudo.fixo.telefone.numero', line 1, position 2411.
                ConsultaCPFResponseResult = Newtonsoft.Json.JsonConvert.DeserializeObject<ConsultaCPFResponse>(json);
            } else {
                var content = await response.Content.ReadAsStringAsync();
                throw new Exception(content);
            }
        }
    }
}

public class CPFRequest {
    public string cpf { get; set; }
}
