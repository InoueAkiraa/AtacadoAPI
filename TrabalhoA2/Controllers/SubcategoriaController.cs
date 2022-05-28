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
    public class SubcategoriaController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        public SubcategoriaController() : base()
        { }

        /// <summary>
        /// Lista todas as subcategorias
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<SubCategoria> GetAll()
        {
            return Estoque.SubCategorias;
        }
        /// <summary>
        /// Lista a subcategoria peolo ID
        /// </summary>
        /// <param name="id">Chave da pesquisa</param>
        /// <returns>Localizado</returns>
        [HttpGet("porid/{id:int}")]
        public SubCategoria GetByID(int id)
        {
            return Estoque.SubCategorias.SingleOrDefault(sub => sub.SubCategoriaId == id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomeParcial"></param>
        /// <returns></returns>
        [HttpGet("pornome/{nomeParcial}")]
        public List<SubCategoria> GetByName(string nomeParcial)
        {
            return Estoque.SubCategorias.Where(sub => sub.Descricao.StartsWith(nomeParcial)).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        [HttpGet("porcategoria/{categoria:int}")]
        public List<SubCategoria> GetByCategoria(int categoria)
        {
            return Estoque.SubCategorias.Where(sub => sub.CategoriaId == categoria).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        [HttpPost]
        public SubCategoria Post([FromBody] SubCategoria dados)
        {
            int chave = Estoque.SubCategorias.Max(sub => sub.SubCategoriaId) + 1;
            dados.SubCategoriaId = chave;
            Estoque.SubCategorias.Add(dados);
            return dados;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        [HttpPut]
        public SubCategoria Put([FromBody] SubCategoria dados)
        {
            int id = dados.SubCategoriaId;
            SubCategoria alt = Estoque.SubCategorias.SingleOrDefault(sub => sub.SubCategoriaId == id);
            if (alt != null)
            {
                alt.Descricao = dados.Descricao;
                alt.DataDeInsercao = dados.DataDeInsercao;
            }
            return alt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        [HttpDelete]
        public SubCategoria Delete([FromBody] SubCategoria dados)
        {
            int id = dados.SubCategoriaId;
            SubCategoria del = Estoque.SubCategorias.SingleOrDefault(sub => sub.SubCategoriaId == id);
            if (del != null)
            {
                Estoque.SubCategorias.Remove(del);
            }
            return del;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public SubCategoria DeleteByID(int id)
        {
            SubCategoria del = Estoque.SubCategorias.SingleOrDefault(sub => sub.SubCategoriaId == id);
            if (del != null)
            {
                Estoque.SubCategorias.Remove(del);
            }
            return del;
        }
    }
}
