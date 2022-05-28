using System;
using System.Collections.Generic;

namespace AulaApp.FakeDB
{
	public static class SubcategoriaFakeDB
	{
		private static List<SubCategoria> subCategorias = new List<SubCategoria>();
		
        public static List<SubCategoria> SubCategorias
        {
            get
            {
                if (subCategorias.Count() == 0)
                {
                    InicializarSubCategorias();
                }
                return subCategorias;
            }
        }

        private static void InicializarSubCategorias()
        {
			subCategorias.Add(new SubCategoria(1, 1, "Papinha", DateTime.Now));
			subCategorias.Add(new SubCategoria(2, 1, "Sopinha", DateTime.Now));
			subCategorias.Add(new SubCategoria(3, 2, "Proteína", DateTime.Now));
			subCategorias.Add(new SubCategoria(4, 2, "Carboidratos", DateTime.Now));
			subCategorias.Add(new SubCategoria(5, 2, "Vitaminas", DateTime.Now));
			subCategorias.Add(new SubCategoria(6, 2, "Hipercalóricos", DateTime.Now));
			subCategorias.Add(new SubCategoria(7, 2, "Óxido Nítrico", DateTime.Now));
			subCategorias.Add(new SubCategoria(8, 2, "Aminoácidos", DateTime.Now));
			subCategorias.Add(new SubCategoria(9, 2, "Propriedade Funcional", DateTime.Now));
			subCategorias.Add(new SubCategoria(10, 3, "Achocolatados", DateTime.Now));
			subCategorias.Add(new SubCategoria(11, 3, "Bebidas a Base de Soja", DateTime.Now));
			subCategorias.Add(new SubCategoria(12, 3, "Bebidas Alcoólicas", DateTime.Now));
			subCategorias.Add(new SubCategoria(13, 3, "Café e Cia", DateTime.Now));
			subCategorias.Add(new SubCategoria(14, 3, "Chás", DateTime.Now));
			subCategorias.Add(new SubCategoria(15, 3, "Isotônicos e Energéticos", DateTime.Now));
			subCategorias.Add(new SubCategoria(16, 3, "Refrescos em Pó", DateTime.Now));
			subCategorias.Add(new SubCategoria(17, 3, "Refrigerantes", DateTime.Now));
			subCategorias.Add(new SubCategoria(18, 3, "Sucos Concentrados", DateTime.Now));
			subCategorias.Add(new SubCategoria(19, 3, "Sucos de Frutas Prontos", DateTime.Now));
			subCategorias.Add(new SubCategoria(20, 3, "Sucos Naturais", DateTime.Now));
			subCategorias.Add(new SubCategoria(21, 3, "Sucos Orgânicos", DateTime.Now));
			subCategorias.Add(new SubCategoria(22, 4, "Biscoitos e Bolachas", DateTime.Now));
			subCategorias.Add(new SubCategoria(23, 4, "Bolos Caseiros", DateTime.Now));
			subCategorias.Add(new SubCategoria(24, 4, "Bolos Prontos", DateTime.Now));
			subCategorias.Add(new SubCategoria(25, 4, "Misturas para Bolos", DateTime.Now));
			subCategorias.Add(new SubCategoria(26, 5, "Aves (Frango, Peru, etc)", DateTime.Now));
			subCategorias.Add(new SubCategoria(27, 5, "Boi", DateTime.Now));
			subCategorias.Add(new SubCategoria(28, 5, "Frutos do Mar", DateTime.Now));
			subCategorias.Add(new SubCategoria(29, 5, "Hamburguers", DateTime.Now));
			subCategorias.Add(new SubCategoria(30, 5, "Outras Carnes", DateTime.Now));
			subCategorias.Add(new SubCategoria(31, 5, "Peixes", DateTime.Now));
			subCategorias.Add(new SubCategoria(32, 5, "Porco", DateTime.Now));
			subCategorias.Add(new SubCategoria(33, 5, "Vitela", DateTime.Now));
			subCategorias.Add(new SubCategoria(34, 6, "Empanados", DateTime.Now));
			subCategorias.Add(new SubCategoria(35, 6, "Hamburguers", DateTime.Now));
			subCategorias.Add(new SubCategoria(36, 6, "Legumes & Cia Congelados", DateTime.Now));
			subCategorias.Add(new SubCategoria(37, 6, "Pizzas Congeladas", DateTime.Now));
			subCategorias.Add(new SubCategoria(38, 6, "Polpas de Frutas Congeladas", DateTime.Now));
			subCategorias.Add(new SubCategoria(39, 6, "Pratos Prontos Congelados", DateTime.Now));
			subCategorias.Add(new SubCategoria(40, 6, "Salgados Congelados", DateTime.Now));
			subCategorias.Add(new SubCategoria(41, 7, "Conservas em Geral", DateTime.Now));
			subCategorias.Add(new SubCategoria(42, 8, "Adoçantes", DateTime.Now));
			subCategorias.Add(new SubCategoria(43, 8, "Balas", DateTime.Now));
			subCategorias.Add(new SubCategoria(44, 8, "Chicletes", DateTime.Now));
			subCategorias.Add(new SubCategoria(45, 8, "Chocolates", DateTime.Now));
			subCategorias.Add(new SubCategoria(46, 8, "Doces de Frutas", DateTime.Now));
			subCategorias.Add(new SubCategoria(47, 8, "Doces Diversos", DateTime.Now));
			subCategorias.Add(new SubCategoria(48, 8, "Gelatinas", DateTime.Now));
			subCategorias.Add(new SubCategoria(49, 8, "Geléias", DateTime.Now));
			subCategorias.Add(new SubCategoria(50, 8, "Ingredientes Doces", DateTime.Now));
			subCategorias.Add(new SubCategoria(51, 8, "Mel e Xaropes", DateTime.Now));
			subCategorias.Add(new SubCategoria(52, 8, "Sobremesas em Pó", DateTime.Now));
			subCategorias.Add(new SubCategoria(53, 8, "Sobremesas Lácteas", DateTime.Now));
			subCategorias.Add(new SubCategoria(54, 8, "Sorvetes", DateTime.Now));
			subCategorias.Add(new SubCategoria(55, 8, "Tortas", DateTime.Now));
			subCategorias.Add(new SubCategoria(56, 9, "Cereal Matinal", DateTime.Now));
			subCategorias.Add(new SubCategoria(57, 9, "Farinhas e Cereais Diversos", DateTime.Now));
			subCategorias.Add(new SubCategoria(58, 9, "Mingau e Cia", DateTime.Now));
			subCategorias.Add(new SubCategoria(59, 10, "Amendoim e Etc", DateTime.Now));
			subCategorias.Add(new SubCategoria(60, 10, "Batata Frita", DateTime.Now));
			subCategorias.Add(new SubCategoria(61, 10, "Bobs", DateTime.Now));
			subCategorias.Add(new SubCategoria(62, 10, "Casa da Empada", DateTime.Now));
			subCategorias.Add(new SubCategoria(63, 10, "Habibs", DateTime.Now));
			subCategorias.Add(new SubCategoria(64, 10, "Mc Donalds", DateTime.Now));
			subCategorias.Add(new SubCategoria(65, 10, "Pastas & Patês", DateTime.Now));
			subCategorias.Add(new SubCategoria(66, 10, "Petiscos Diversos", DateTime.Now));
			subCategorias.Add(new SubCategoria(67, 10, "Pipoca", DateTime.Now));
			subCategorias.Add(new SubCategoria(68, 10, "Pizzas Congeladas", DateTime.Now));
			subCategorias.Add(new SubCategoria(69, 10, "Rei do Mate", DateTime.Now));
			subCategorias.Add(new SubCategoria(70, 10, "Salgadinhos & Snacks", DateTime.Now));
			subCategorias.Add(new SubCategoria(71, 11, "Frios e Embutidos em Geral", DateTime.Now));
			subCategorias.Add(new SubCategoria(72, 12, "Doces de Frutas", DateTime.Now));
			subCategorias.Add(new SubCategoria(73, 12, "Frutas Diversas", DateTime.Now));
			subCategorias.Add(new SubCategoria(74, 12, "Frutas Secas e em Calda", DateTime.Now));
			subCategorias.Add(new SubCategoria(75, 12, "Polpas de Frutas Congeladas", DateTime.Now));
			subCategorias.Add(new SubCategoria(76, 12, "Sucos Concentrados", DateTime.Now));
			subCategorias.Add(new SubCategoria(77, 12, "Sucos de Frutas Prontos", DateTime.Now));
			subCategorias.Add(new SubCategoria(78, 12, "Sucos Naturais", DateTime.Now));
			subCategorias.Add(new SubCategoria(79, 12, "Sucos Orgânicos", DateTime.Now));
			subCategorias.Add(new SubCategoria(80, 13, "Legumes & Cia Congelados", DateTime.Now));
			subCategorias.Add(new SubCategoria(81, 13, "Legumes e Cia Naturais", DateTime.Now));
			subCategorias.Add(new SubCategoria(82, 14, "Massas em Geral", DateTime.Now));
			subCategorias.Add(new SubCategoria(83, 15, "Caldos", DateTime.Now));
			subCategorias.Add(new SubCategoria(84, 15, "Catchup & Mostarda", DateTime.Now));
			subCategorias.Add(new SubCategoria(85, 15, "Maionese", DateTime.Now));
			subCategorias.Add(new SubCategoria(86, 15, "Molhos", DateTime.Now));
			subCategorias.Add(new SubCategoria(87, 15, "Outros Condimentos", DateTime.Now));
			subCategorias.Add(new SubCategoria(88, 16, "Iogurtes", DateTime.Now));
			subCategorias.Add(new SubCategoria(89, 16, "Leite", DateTime.Now));
			subCategorias.Add(new SubCategoria(90, 16, "Milkshakes", DateTime.Now));
			subCategorias.Add(new SubCategoria(91, 16, "Ovos", DateTime.Now));
			subCategorias.Add(new SubCategoria(92, 16, "Queijos", DateTime.Now));
			subCategorias.Add(new SubCategoria(93, 16, "Sobremesas Lácteas", DateTime.Now));
			subCategorias.Add(new SubCategoria(94, 17, "Pães em Geral", DateTime.Now));
			subCategorias.Add(new SubCategoria(95, 18, "Sopas em Geral", DateTime.Now));
			subCategorias.Add(new SubCategoria(96, 19, "Diversos sem Categoria", DateTime.Now));
		}		
	}
}


