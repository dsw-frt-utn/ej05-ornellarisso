using Dsw2026Ej5.Data;
using Dsw2026Ej5.Views;

namespace Dsw2026Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persistencia.InicializarDatos();

            bool continuar = true;
            while (continuar)
            {
                ConsoleView.DibujarMenu();
            }
        }
    }
}