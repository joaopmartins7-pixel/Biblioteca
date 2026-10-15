namespace Biblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string codigo_identificacao { get; set; }
        public string titulo { get; set; }
        public string nome_autor{ get; set; }
        public DateTime ano_publicacao { get; set; }
    }
}
