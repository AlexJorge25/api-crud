using System.Text.Json.Serialization;

namespace CrudApi
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public int Estoque { get; set; }
        public Categorias Categoria { get; set; }

        [JsonIgnore]
        public int CategoriaId { get; set; }

    }
}
