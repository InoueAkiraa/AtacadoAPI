using System;
using System.Collections.Generic;

namespace AulaApp
{
    public class Categoria : CamposComuns, IImpressao
    {
        private int categoriaId;

        private List<SubCategoria> subCategorias;

        public int CategoriaId
        {
            get => this.categoriaId;
            set => this.categoriaId = value;
        }

        public List<SubCategoria> SubCategorias 
        { 
            get => this.subCategorias; 
            set => this.subCategorias = value; 
        }

        public Categoria() : base()
        {
            this.subCategorias = new List<SubCategoria>();
        }

        public Categoria(int id, string descricao, DateTime data)
            : base(descricao, data)
        {
            this.categoriaId = id;
            this.subCategorias = new List<SubCategoria>();
        }

        public void Imprimir()
        {
            Console.WriteLine("ID: {0}", this.categoriaId);
            Console.WriteLine("Descrição: {0}", this.descricao);
            Console.WriteLine("Data: {0}", this.dataDeInsercao);
        }
    }
}
