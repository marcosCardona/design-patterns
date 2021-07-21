using System.Net;

namespace AppPatronesDiseño.Patrones._1.Builder
{
    public class RequestAssembly
    {
        private RequestBuilder _requestBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        public RequestAssembly(RequestBuilder requestBuilder)
        {
            _requestBuilder = requestBuilder;
        }

        public HttpStatusCode Assemble()
        {
            _requestBuilder.AgregarParametrosCuerpo();
            _requestBuilder.AgregarParametrosCabecera();
            return _requestBuilder.ArmarPeticionAsync();
        }

        public Request ObtenerRequest()
        {
            return _requestBuilder.Request;
        }
    }
}