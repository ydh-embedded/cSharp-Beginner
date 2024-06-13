namespace Strings;

public class Prg
{
    static void Main(string[] args)
    {
        string sName = "Alice";
        // wenn man return mStringIndicies definiert,
        // ruft sich die funktion selber wieder auf => Gefahr von
        // StackOverflow
        
        
        mStringIndicies(sName);
        mStringLaenge();
        mStringJoin();
        mStringCharArray(sName);
        mStringRange(sName);
        
        
        static string mStringIndicies(string sName)
        {
            // char vSecondChar = sName[1];
            // char vThirdChar = sName[2];
            char vFirstChar = sName[0];
            char vLastChar = sName[^1];
            
            // string sName = "Alice";
            Console.WriteLine("\ud83d\udc2c" 
                + vFirstChar
                + ""
                + vLastChar
                + "\n");
            return sName; 
        }
        
        
        static string mStringLaenge( )
        {
            string sName = "Alice";
            Console.WriteLine("\ud83d\udc2c" 
                + $"Die Zeichen-Länge von {sName} hat {sName.Length} Charactere"
                + "\n");
            return sName;
        }


        static string mStringJoin( )
        {
            string sName = "Alice";
            Console.WriteLine("\ud83d\udc2c" 
                              + string.Join(":" , "Alice" , "Bob" , "Charlie")
                              + "\n");
            return sName;
        }

        
        static string mStringCharArray(string sName)
        {
            char[] vCharacters = sName.ToCharArray();
            sName = "damian";
            string sLastThreeChars = sName.Substring(sName.Length - 3, 3);
            Console.WriteLine(sLastThreeChars);
            return(sName);
        }


        static string mStringRange(string sName)
        {
            char[] cLastThreeChars = sName.ToCharArray();
            string sLastThreeChars = sName[^3..];
            Console.WriteLine("\ud83d\udc2c" 
                              + "   "
                              + $"Der String von {sName} wird in das Array {cLastThreeChars} exportiert"
                              + "\n"
                              );
            Console.WriteLine("\ud83d\udc2c" 
                              + "   "
                              + $"Die letzten 3 Characters von  >> {sName} <<  werden in ein String exportiert: >> {sLastThreeChars} << "
                              + "\n"
                              );
            return sName;
        }
        
        
        
        
        
        
        
        
    }
}