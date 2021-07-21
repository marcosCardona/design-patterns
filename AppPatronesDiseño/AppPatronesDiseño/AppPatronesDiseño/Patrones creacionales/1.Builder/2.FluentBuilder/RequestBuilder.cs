using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace AppPatronesDiseño.Patrones._1_2.FluentBuilder
{
    public class FluentRequestBuilder
    {
        private JObject Contenido { get; set; }

        public HttpClient ClienteHttp { get; private set; }
        public bool EsPost { get; set; }
        public bool UsaProxy { get; set; }
        public string Url { get; set; }
        public Dictionary<string, string> ParametrosCabecera { get; set; }
        public Dictionary<string, string> ParametrosCuerpo { get; set; }

        public FluentRequestBuilder CargarValores(bool esPost, bool usaProxy, string url, Dictionary<string, string> parametrosCabecera, Dictionary<string, string> parametrosCuerpo)
        {
            EsPost = esPost;
            UsaProxy = usaProxy;
            Url = url;
            ParametrosCabecera = parametrosCabecera;
            ParametrosCuerpo = parametrosCuerpo;

            return this;
        }

        public FluentRequestBuilder AgregarParametrosCabecera()
        {
            if (ParametrosCabecera != null)
            {
                // Agregar parametros a la cabecera del cliente http
                foreach (var parametro in ParametrosCabecera)
                    ClienteHttp.DefaultRequestHeaders.Add(parametro.Key, parametro.Value);
            }

            return this;
        }

        public FluentRequestBuilder AgregarParametrosCuerpo()
        {
            if (ParametrosCuerpo != null)
            {
                var jObject = new JObject();
                // Recorrer y setear jObject
                foreach (var parametro in ParametrosCuerpo)
                    jObject.Add(parametro.Key, parametro.Value);

                Contenido = jObject;
            }

            return this;
        }

        public HttpStatusCode ArmarPeticionAsync()
        {
            try
            {
                // Crear Handler para proxy
                var handler = new HttpClientHandler();

                // Verificar uso de proxy
                if (!UsaProxy)
                    handler.UseProxy = false;

                // Instanciar HttpClient
                ClienteHttp = new HttpClient(handler);

                // Verificar Si es Post o Get
                var verboHttp = EsPost ? HttpMethod.Post : HttpMethod.Get;

                using (var request = new HttpRequestMessage(verboHttp, Url))
                {
                    if (EsPost)
                    {
                        var jsonString = "";
                        if (Contenido != null)
                            jsonString = JsonConvert.SerializeObject(Contenido);

                        using (var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json"))
                        {
                            request.Content = stringContent;
                            // Obtener response y retornar StatusCode
                            var response = ClienteHttp.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false).GetAwaiter();
                            var resultado = response.GetResult();
                            return resultado.StatusCode;
                        }
                    }
                    else
                    {
                        // Obtener response y retornar StatusCode
                        var response = ClienteHttp.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false).GetAwaiter();
                        var resultado = response.GetResult();
                        return resultado.StatusCode;
                    }

                }
            }
            catch (Exception ex)
            {
                return HttpStatusCode.InternalServerError;
            }

        }
    }
}