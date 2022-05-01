using Api_Biblioteca.Interfaces;

namespace Api_Biblioteca.Services

{
    public class AmbienteServices : IAmbienteService
    {
         public readonly IConfiguration _configuration;

        public string ObterAmbiente(){

            return _configuration.GetSection("NomeAmbiente").Value;
        }

        public AmbienteServices(IConfiguration configuration){
            this._configuration = configuration;
        }

        

    }
}