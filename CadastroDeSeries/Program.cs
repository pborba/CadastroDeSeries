using CadastroDeSeries.Classes;
using System;

namespace CadastroDeSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            SeriesMenu seriesMenu = new SeriesMenu();

            while(true)
            {
                seriesMenu.imprimirMenu();
                var opcao = Console.ReadLine();
                seriesMenu.selecionarOpcaoMenu(opcao);
            }

        }
    }
}
