using System.Net;

namespace AppPatronesDiseño.Patrones._1.Builder
{
    public abstract class RequestBuilder
    {
        protected Request _request;

        public Request Request { get { return _request; } }

        public abstract void AgregarParametrosCabecera();
        public abstract void AgregarParametrosCuerpo();
        public abstract HttpStatusCode ArmarPeticionAsync();
    }
}