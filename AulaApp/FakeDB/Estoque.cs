using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaApp.FakeDB
{
    public static class Estoque
    {
        public static List<Categoria> Categorias
        {
            get { return CategoriaFakeDB.Categorias; } 
        }

        public static List<SubCategoria> SubCategorias
        {
            get { return SubcategoriaFakeDB.SubCategorias; }
        }

        public static List<Produto> Produtos
        {
            get { return ProdutoFakeDB.Produtos; }
        }
    }
}
