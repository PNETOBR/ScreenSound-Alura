using ScreenSound03.Menus;
using ScreenSound03.Models;

namespace ScreenSound03.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau ;) ");
    }
}
