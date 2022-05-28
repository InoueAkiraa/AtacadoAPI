using System;
using System.Collections.Generic;

namespace AulaApp.FakeDB
{
	public static class CategoriaFakeDB
	{
		private static List<Categoria> categorias = new List<Categoria>();
		
        public static List<Categoria> Categorias
        {
            get
            {
                if (categorias.Count() == 0)
                {
                    InicializarCategorias();					
                }
                return categorias;
            }
        }

		public static void Add(Categoria categoria)
		{ 
			categorias.Add(categoria);
		}

        private static void InicializarCategorias()
        {
			categorias.Add(new Categoria(1, "Alimento Infantil", DateTime.Now));
			categorias.Add(new Categoria(2, "Suplementos", DateTime.Now));
			categorias.Add(new Categoria(3, "Bebidas", DateTime.Now));
			categorias.Add(new Categoria(4, "Biscoitos, Bolos e Bolachas", DateTime.Now));
			categorias.Add(new Categoria(5, "Carnes", DateTime.Now));
			categorias.Add(new Categoria(6, "Congelados", DateTime.Now));
			categorias.Add(new Categoria(7, "Conservas", DateTime.Now));
			categorias.Add(new Categoria(8, "Doces, Balas, Chocolates e Cia", DateTime.Now));
			categorias.Add(new Categoria(9, "Farinhas, Cereais e Complementos", DateTime.Now));
			categorias.Add(new Categoria(10, "Fast-Food, Aperitivos e Petiscos", DateTime.Now));
			categorias.Add(new Categoria(11, "Frios e Embutidos", DateTime.Now));
			categorias.Add(new Categoria(12, "Frutas", DateTime.Now));
			categorias.Add(new Categoria(13, "Legumes, Verduras e Grãos", DateTime.Now));
			categorias.Add(new Categoria(14, "Massas", DateTime.Now));
			categorias.Add(new Categoria(15, "Molhos, Caldos e Condimentos", DateTime.Now));
			categorias.Add(new Categoria(16, "Ovos, Leite, Queijo e Cia", DateTime.Now));
			categorias.Add(new Categoria(17, "Pães", DateTime.Now));
			categorias.Add(new Categoria(18, "Sopas & Cremes", DateTime.Now));
			categorias.Add(new Categoria(19, "Diversos", DateTime.Now));
        }		
	}
}