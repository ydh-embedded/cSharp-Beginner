using MyCompany.Games.Pacman; // ich möchte den folgenden Bezeichner in Zeile 8 unqualifiziert verwenden
                              // und importiere mit using MyCompany.Games.Pacman

using TetrisGame = MyCompany.Games.Tetris.MyClass; // Wir verwenden eine 'Alias' für den vollqualifizierten Namen
using TetrisNameSpace = MyCompany.Games.Tetris;   // Wir verwenden eine 'Alias' für den vollqualifizierten Namespaces / Namensraum


namespace MyCompany.Games
{
    class App // internal class App
    {
        static void Main(string[] args)
        {
            MyCompany.Games.Pacman.MyClass mMyClass = new MyCompany.Games.Pacman.MyClass(); // hier rufen wir den Construktor der classe MyClass mit MyClass() auf


            TetrisGame vTetrisDame = new TetrisGame();              // Verwendung einer classe mit einem 'Alias'
       //     TetrisNameSpaces.MyClass vAnotherTetrisGame = new TetrisNameSpaces.MyClass();              // Verwendung einer classe mit einem 'Alias'
            
        }
    }
    
}

public class App
{
    
}