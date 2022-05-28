using AulaApp;
using AulaApp.FakeDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        public CategoriaController() : base() // é usada para acessar membros da classe base de dentro de uma classe derivada
        { }

        /// <summary>
        /// Lista todas as categorias
        /// </summary>
        /// <returns>Todos os registros</returns>
        [HttpGet]
        public List<Categoria> GetAll()
        {
            return Estoque.Categorias; //retorna todas as Categorias presentes no estoque
        }

        /// <summary>
        /// Consulta a categoria usando a chave ID
        /// </summary>
        /// <param name="id">Chave da pesquisa</param>
        /// <returns>Registro Localizado</returns>
        [HttpGet("{id:int}")]
        public Categoria GetByID(int id) 
        {
            return Estoque.Categorias.SingleOrDefault(cat => cat.CategoriaId == id);
        } //retorna um elemento específico de uma coleção se o elemento bate com seus critérios estabelecidos.

        /// <summary>
        /// Consulta a categoria utilizando o nome
        /// </summary>
        /// <param name="nomeParcial">Descrição parcial</param>
        /// <returns>Registro Localizado</returns>
        [HttpGet("{nomeParcial}")]
        public List<Categoria> GetByName(string nomeParcial)
        {
            return Estoque.Categorias.Where(cat => cat.Descricao.StartsWith(nomeParcial)).ToList();
        }// WHERE é usada na consulta para especificar quais elementos da fonte de dados serão retornados
         //na expressão de consulta

        /// <summary>
        /// Realizar a criação de um registro
        /// </summary>
        /// <param name="dados">novo registro que será incluído</param>
        /// <returns>Registro Criado</returns>
        [HttpPost]
        public Categoria Post([FromBody] Categoria dados) //força a API a ler um tipo simples do corpo da solicitação
        {
            int chave = Estoque.Categorias.Max(cat => cat.CategoriaId) + 1; //Vai pegar o valor máximo de Categoria e adicionar 1
            dados.CategoriaId = chave;
            Estoque.Categorias.Add(dados); //Adiciona as informações novas que foram gravadas em dados, através da variável chave
            return dados;
        }

        /// <summary>
        /// Realizar a alteração de um registro
        /// </summary>
        /// <param name="dados">Registro que será editado</param>
        /// <returns>Registro Alterado</returns>
        [HttpPut]
        public Categoria Put([FromBody] Categoria dados)
        {
            int id = dados.CategoriaId;
            Categoria alt = Estoque.Categorias.SingleOrDefault(cat => cat.CategoriaId == id);
            if (alt != null)
            {
                alt.Descricao = dados.Descricao; // irá a
                alt.DataDeInsercao = dados.DataDeInsercao;
            }
            return alt;
        }

        /// <summary>
        /// Excluir um registro existente
        /// </summary>
        /// <param name="dados">Dados do registro</param>
        /// <returns>Registro Excluído</returns>
        [HttpDelete]
        public Categoria Delete([FromBody] Categoria dados)
        {
            int id = dados.CategoriaId;
            Categoria del = Estoque.Categorias.SingleOrDefault(cat => cat.CategoriaId == id);
            if (del != null)
            {
                Estoque.Categorias.Remove(del);
            }
            return del;
        }

        /// <summary>
        /// Excluir um registro utilizando a chave ID
        /// </summary>
        /// <param name="id">Chave para localização</param>
        /// <returns>Registro Excluído</returns>
        [HttpDelete("{id:int}")]
        public Categoria DeleteByID(int id)
        {
            Categoria del = Estoque.Categorias.SingleOrDefault(cat => cat.CategoriaId == id);
            if (del != null)
            {
                Estoque.Categorias.Remove(del);
            }
            return del;
        }
    }
}
