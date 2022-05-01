using Microsoft.AspNetCore.Mvc;
using Api_Biblioteca.Entities;


namespace LivrosController.Controllers {


    //[ApiController]
    [Route("/api/livros/[controller]")]

    public class AlunosController : ControllerBase 
    {

        [HttpGet]
        public List<Livro> ObterTodos(){

        Livro livro1 = new Livro("Dom Quixote", "Miguel de Cervantes");
        Livro livro2 = new Livro("Guerra e Paz", "Liev Tolstói");
        Livro livro3 = new Livro("A Montanha Mágica", "Thomas Mann");
        Livro livro4 = new Livro("Cem Anos de Solidão", "Gabriel García Márquez");

        var ListaLivros = new List<Livro>();

        ListaLivros.Add(livro1);
        ListaLivros.Add(livro2);
        ListaLivros.Add(livro3);
        ListaLivros.Add(livro4);

        return ListaLivros;

        }

        [HttpGet("obter-por-id")]

        public void ObterPorId(){


        }

        [HttpPost("inserir")]

        public ActionResult Inserir(string titulo, string autor){

            
            if(!ModelState.IsValid){

                return BadRequest();

            } else{
                return Ok();
            }

        }

        [HttpPut("atualizar")]

        public void Atualizar(){

        }

        [HttpDelete("excluir")]

        public void Excluir(){

        }


    }

}