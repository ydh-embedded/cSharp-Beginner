# Wir machen eine Fall-Unterscheidung mit Switch

````csharp

    static void SwitchStatement()
    {
        int age = 18;
        const int x = 19;           // hier muss eine const die zur lauf zeit berechnet werden kann

        
        switch (age)                // switch (Ausdruck) {...}
        {
            case 10 Pattern:       // Konstanter Pattern
                Anweisungen;
                break;    
    
            case 10 or 8 and 6 not 3  or x Pattern:      // logical Pattern
                Anweisungen;
                break;
            
            case >= 13 and <= 19    // Kombi aus relational Pattern & logical Pattern
                Anweisung;
                Console.WriteLine("Text ");
                
            case >= 20              // relational Pattern erlaubt Vergleiche mit Konstanten
                Anweisung;
                Console.WriteLine("Text ");
                

            default:
                Console.WriteLine("Text ");
                break;
        }
    }
````

## Boolsche Algebra

````csharp

    // Vorrang
    
        NOT > AND > OR
            
````
            
````csharp

        switch (name,alter,gender,gehalt)      // positional Pattern ist ein zusammengesetztes Pattern z.B. tupel (string,int,char)
        {
            case ( _, >= 4, _, _ ):          // discard Pattern matched die Werte ohne die auswahl zu beeinflussen
                isSuitable = false ;
                break;
            
            case (_, _, _, >= 100_000):
                isSuitable = false;
                break;
            
            
````            
## discard-Pattern mit kombi
````csharp

        switch (name,alter,gender,gehalt)      // positional Pattern ist ein zusammengesetztes Pattern z.B. tupel (string,int,char)
        {
            case ( _, >= 4, _, _ ) or (_, _, _, >= 100_000):          // discard Pattern matched die Werte ohne die auswahl zu beeinflussen
                isSuitable = false ;
                break;
            
            case :
                isSuitable = false;
                break;
            
            
````

## var-Pattern

````csharp

        switch (name,alter,gender,gehalt)        // positional Pattern ist ein zusammengesetztes Pattern z.B. tupel (string,int,char)
        {                                       // wir erstellen eine variable criteria diese ist vom Typ Tupel
            case var criteria:                                       // var Pattern matched ALLE Werte - aber beeinflusst die Auswahl
                isSuitable = criteria.gender == 'm' && age >= 50;   // isSuitable = true
                break;      
                
                // Wenn ein var Pattern verwendet wird braucht man kein default zum Schluss
            
````

## positional-Pattern

````csharp

        switch (alice)        // positional Pattern ist ein zusammengesetztes Pattern z.B. aus
                             // discard-Pattern >> ( var name,_ , true ) << und dem
                            // case-guard >> ( when name.StartsWith("M") || name.StartsWith("A") ) <<
        {                                       
            
            case (var name,_ , true) when ( name.StartsWith("M") || name.StartsWith("A") ):
                isSuitable = criteria.gender == 'm' && age >= 50;   // isSuitable = true
                break;      
                
                // Wenn ein var Pattern verwendet wird braucht man kein default zum Schluss
            
````
