using Microsoft.AspNetCore.Mvc;



namespace AmbienteController.Controllers {

        [ApiController]
        [Route("/api/ambiente/")]
    public class AmbienteController : ControllerBase{
        

        
        public readonly IConfiguration _configuration;

        public AmbienteController(IConfiguration configuration){

       _configuration = configuration;


        }

        [HttpGet]
        
        public string Get(){
        return _configuration.GetSection("NomeAmbiente").Value;
        }
        


    }
}