namespace CrudApi
{
    public class CategoriaDTO
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; }
    }

}
