using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lazuli.Core.Responses
{
    public abstract class Response<TData>
    {
        // http status code
        private int _code = Configuration.DefaultStatusCode;
        // se o codigo esta entre 200 e 299 é um codigo de sucesso! 
        [JsonIgnore]
        public bool IsSucess => _code is >= 200 and <= 299;

        //Construtor vazio para evitar erros em json
        [JsonConstructor]
        public Response() => _code = Configuration.DefaultStatusCode;

        // Exemplo de de Response: var res = new Response<Category>(model);
        // Optional Parameters
        public Response(
            TData? data,
            int code = Configuration.DefaultStatusCode,
            string? message = null )
        {
            Data = data;
            _code = code;
            Message = message;
        }

        public string? Message { get; set; }
        public TData? Data { get; set; }
    }
}