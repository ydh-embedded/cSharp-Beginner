namespace Exceptions;
using static Exceptions.SOF;


public class Prg
{
    static void Main(string[] args)
    {
        try
        {
           mTryCatchFinally();
        }
        catch (Exception e)
        {
            Console.WriteLine("\ud83d\udca9"
                              + "   "
                              + "Eine Exception wurde an die Main übergeben, dass Prg wird beendet"
                              + "\n"
                              );
            Console.WriteLine("\ud83d\udca9"
                              + "   "
                              + "Hier ist die Exception vom Compiler: "
                              + e
                              + "\n"
                              );
            
           SOF.mPreventativeExample();      // Wir rufen die Methode mPreventativeExample von der class SOF auf.
            throw;
        }
    }
    static void mTryCatchFinally()
    {
        try
        {
            // double dZero = 0;
            int iZero    = 0;
            double dResult = 5 / iZero;
            Console.WriteLine($"Das Ergebnis ist {dResult} ");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine( "\ud83d\udca9"
                               + "   "
                               +"Division durch Null ist Mathematisch unzulässig"
                               + "\n");
            Console.WriteLine("\ud83d\udca9"
                              + e.StackTrace
                              + "\ud83d\udc1e"
                              + "\n");
            throw new ("\n" 
                       + "\ud83d\udca9"
                       + "   "
                       + "Berechnungsfehler: >>Throw<< New hat die Exception an die Main zurück gerufen"
                       + "\n"
                       + "\ud83d\udc1e"
                       + "   "
                       + "Hier ist die Exception vom Compiler"
                       + "\n"
                       + e
                       );
        }
        finally
        {
            Console.WriteLine("\ud83d\udca9"
                              + "   "
                              + "Finally wurde ausgeführt und die Exception ausgeworfen"
                              + "\n"
                              );
        }
    }
}