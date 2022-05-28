using Microsoft.AspNetCore.Http;
using AulaApp; // projeto
using AulaApp.FakeDB; // nome da pasta
using Microsoft.AspNetCore.Mvc;

namespace AtacadoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public ProdutosController() : base() // puxa informações do controller base
        { }

        [HttpGet] //consulta
        public List<Produto> GetAll()
        { return Estoque.Produtos; } //nome da propriedade

        [HttpGet("porid/{id:int}")]
        public Produto GetByID(int id)
        {
            return Estoque.Produtos.SingleOrDefault(pro => pro.ProdutoId == id);
        }

        [HttpGet("pornome/{nomeParcial}")]
        public List<Produto> GetByName(string nomeParcial)
        {
            return Estoque.Produtos.Where(pro => pro.Descricao.StartsWith(nomeParcial)).ToList();
        }

        [HttpGet("porcategoria/{cat:int}")]
        public List<Produto> GetByCategoria(int cat)
        {
            return Estoque.Produtos.Where(pro => pro.CategoriaId == cat).ToList();
        }

        [HttpGet("porsubcategoria/{sub:int}")]
        public List<Produto> GetBySubcategoria(int sub)
        {
            return Estoque.Produtos.Where(pro => pro.SubCategoriaId == sub).ToList();
        }

        [HttpGet("porcategoria/{cat:int}/porsubcategoria/{sub:int}")]
        public List<Produto> GetByCategoriaSubcategoria(int cat, int sub)
        {
            return Estoque.Produtos
                .Where(pro => pro.CategoriaId == cat)
                .Where(pro => pro.SubCategoriaId == sub)
                .ToList();
        }

        [HttpPost]
        public Produto Post([FromBody] Produto dados) 
        {
            int chave = Estoque.Produtos.Max(pro => pro.ProdutoId) + 1; //adiciona 1 a mais no final da lista de produtos
            dados.ProdutoId = chave;
            Estoque.Produtos.Add(dados);
            return dados;
        }

        [HttpPut]
        public Produto Put([FromBody] Produto dados)
        {
            int id = dados.ProdutoId;
            Produto alt = Estoque.Produtos.SingleOrDefault(pro => pro.ProdutoId == id);
            if (alt != null)
            {
                alt.Descricao = dados.Descricao;
                alt.DataDeInsercao = dados.DataDeInsercao;
            }
            return alt;
        }

        [HttpDelete]
        public Produto Delete([FromBody] Produto dados)
        {
            int id = dados.ProdutoId;
            Produto del = Estoque.Produtos.SingleOrDefault(pro => pro.ProdutoId == id);
            if (del != null)
            {
                Estoque.Produtos.Remove(del);
            }
            return del;
        }

        [HttpDelete("{id:int}")]
        public Produto DeleteByID(int id)
        {
            Produto del = Estoque.Produtos.SingleOrDefault(pro => pro.ProdutoId == id);
            if (del != null)
            {
                Estoque.Produtos.Remove(del);
            }
            return del;
        }
    }
}
