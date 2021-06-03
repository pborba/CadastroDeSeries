using CadastroDeSeries.Enum;
using CadastroDeSeries.Classes;
using System;
using System.Linq;

namespace CadastroDeSeries

{
    class SeriesMenu
    {
        SerieRepositorio serieRepositorio;

        public SeriesMenu()
        {
            serieRepositorio = new SerieRepositorio();
        }

        public void imprimirMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("=================================");
            Console.WriteLine("DIO Séries");
            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine("");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");
        }

        public void selecionarOpcaoMenu(string opcao)
        {
            switch (opcao.ToUpper()) {
                case "1":
                    listarSeries();
                    break;
                case "2":
                    inserirNovaSerie();
                    break;
                case "3":
                    atualizarSerie();
                    break;
                case "4":
                    excluirSerie();
                    break;
                case "5":
                    visualizarSerie();
                    break;
                case "C":
                    limparTela();
                    break;
                case "X":
                    sair();
                    break;
            }

        }

        private void listarSeries()
        {
            Console.WriteLine("Listar série");
            Console.WriteLine("");

            foreach (Serie s in serieRepositorio.Lista())
            {
                if(s.Excluido == false)
                {
                    Console.WriteLine(s.ToString());
                }
            }
        }

        private void inserirNovaSerie()
        {
            Console.WriteLine("Inserir série");
            Console.WriteLine("");

            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.Write("| {0} - {1} |", i, System.Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine();

            Console.Write("Digite o número do gênero da série:");
            var genero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série:");
            var titulo = Console.ReadLine();

            Console.Write("Digite a descrição da série:");
            var descricao = Console.ReadLine();

            Console.Write("Digite o ano de início da série:");
            var ano = int.Parse(Console.ReadLine());

            Serie serie = new Serie(Id: serieRepositorio.ProximoId(), titulo, (Genero)genero, descricao, ano);
            serieRepositorio.Insere(serie);
        }

        private void atualizarSerie()
        {
            Console.WriteLine("Atualizar série");
            Console.WriteLine("");

            Console.WriteLine("Digite o id da série:");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Atualiza série");
            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.Write("| {0} - {1} |", i, System.Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o número do gênero da série:");
            var genero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série:");
            var titulo = Console.ReadLine();

            Console.Write("Digite a descrição da série:");
            var descricao = Console.ReadLine();

            Console.Write("Digite o ano de início da série:");
            var ano = int.Parse(Console.ReadLine());

            Serie serie = new Serie(Id: serieRepositorio.ProximoId(), titulo, (Genero)genero, descricao, ano);
            serieRepositorio.Atualiza(id, serie);
        }

        private void excluirSerie()
        {
            Console.WriteLine("Excluir série");
            Console.WriteLine("");

            Console.Write("Digite o id da série:");
            var id = int.Parse(Console.ReadLine());

            serieRepositorio.Exclui(id);
        }

        private void visualizarSerie()
        {
            Console.WriteLine("Visualizar série");
            Console.WriteLine("");
            Console.WriteLine("Digite o id da série:");
            var id = int.Parse(Console.ReadLine());

            var serie = serieRepositorio.RetornaPorId(id);

            Console.WriteLine(serie.ToString());
        }

        private void limparTela()
        {
            Console.Clear();
        }

        private void sair()
        {
            Environment.Exit(0);
        }
    }
}
