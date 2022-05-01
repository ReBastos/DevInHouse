using System.ComponentModel.DataAnnotations;

namespace Api_Biblioteca.Entities
{
    public class Livro
    {
        [Required(ErrorMessage="O título é obrigatório",AllowEmptyStrings=false)]
        public string Titulo { get; set; }

        [Required(ErrorMessage="O autor é obrigatório",AllowEmptyStrings=false)]
        public string Autor { get; set; }


        public Livro(string titulo, string autor) {

            this.Titulo = titulo;
            this.Autor = autor;

        }
    }
}