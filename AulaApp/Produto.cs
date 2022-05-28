using System;

namespace AulaApp
{
    public class Produto : CamposComuns, IImpressao
    {
        private int produtoId;

        private int categoriaId;

        private int subCategoriaId;

        public Produto() : base()
        {}

        public Produto(int produtoId, int subCategoriaId, int categoriaId,  
            string descricao, DateTime data) : base(descricao, data)
        {
            this.produtoId = produtoId;
            this.categoriaId = categoriaId;
            this.subCategoriaId = subCategoriaId;
        }

        public int ProdutoId 
        { 
            get { return this.produtoId; }
            set { this.produtoId = value; }
        }
        
        public int CategoriaId 
        { get => categoriaId; set => categoriaId = value; }
        
        public int SubCategoriaId 
        { get => subCategoriaId; set => subCategoriaId = value; }

        public void Imprimir()
        {
            Console.WriteLine("Produto ID: {0}", this.produtoId);
            Console.WriteLine("SubCategoria ID: {0}", this.subCategoriaId);
            Console.WriteLine("Categoria ID: {0}", this.categoriaId);
            Console.WriteLine("Descrição: {0}", this.descricao);
            Console.WriteLine("Data: {0}", this.dataDeInsercao);
        }
    }
}
