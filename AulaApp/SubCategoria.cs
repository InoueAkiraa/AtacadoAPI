using System;
using System.Collections.Generic;

namespace AulaApp
{    public class SubCategoria : CamposComuns, IImpressao
    {
        private int subCategoriaId;

        private int categoriaId;

        private List<Produto> produtos;

        public int SubCategoriaId
        {
            get => this.subCategoriaId;
            set => this.subCategoriaId = value;            
        }

        public int CategoriaId 
        { 
            get => this.categoriaId; 
            set => this.categoriaId = value; 
        }

        public List<Produto> Produtos
        {
            get { return this.produtos; }
            set { this.produtos = value; }
        }

        public SubCategoria() : base()
        {
            this.produtos = new List<Produto>();
        }

        public SubCategoria(int subCatId, int catId, string descricao, 
            DateTime data) : base(descricao, data)
        {
            this.subCategoriaId = subCatId;
            this.categoriaId = catId;
            this.produtos = new List<Produto>();
        }

        public void Imprimir()
        {
            Console.WriteLine("SubCategoria ID: {0}", this.subCategoriaId);
            Console.WriteLine("Categoria ID: {0}", this.categoriaId);
            Console.WriteLine("Descrição: {0}", this.descricao);
            Console.WriteLine("Data: {0}", this.dataDeInsercao);
        }
    }
}
