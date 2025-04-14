//using System.ComponentModel.DataAnnotations;

//namespace ProdutosApi.Models
//{
//    public class Produto
//    {
//        public Guid Id { get; set; }

//        [Required] 
//        public string Titulo { get; set;}

//        public string Descricao { get;set; }
//        [Range(0.01, double.MaxValue)]
//        public decimal Preco { get; set; }

//        [Required]
//        [Range(0, int.MaxValue)]
//        public int Estoque {  get; set; }

//        public List<string>? Fotos { get; set; } = new();
//    }
//}

using System.ComponentModel.DataAnnotations;

namespace ProdutosApi.Models
{
    public class Produto
    {
        public Guid Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Descricao { get; set; }
        [Range(0.01, double.MaxValue)]
        public decimal Preco { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Estoque { get; set; }

        public List<string>? Fotos { get; set; } = new();
    }
}
