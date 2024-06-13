# Teil 2

## 💩Frage 1  

-       Klassen-Diagramm

## 💩 Frage 2 

### +  bedeutet :
    🦊   -   public
### -  bedeutet :
    🦊   -   private
### \# bedeutet :
    🦊   -   protected

## 💩 Frage 3

    🦊   -   eine Klasse wird als abstract definiert, die noch nicht fertig gestellt wurde
    🦊   -   abstrakte Klassen können als Basis Klassen verwendet werden
    🦊   -   es fehlen die Eigenschaften 
    🦊   -   Methoden können auch abstract sein - Sie besitzen keine Implementierung 
    🦊   -   hashtack Symbol in UML

## 💩 Frage 4  - Messgerät & Messwert

    🦊   -   Aggregation
    🦊   -   Eine 1 zu n Beziehung
    🦊   -   Eine Klasse Messwert ist Teil einer anderen (abstracten) Klasse Messgerät

## 💩 Frage 5  - Messgerät & Hygrometer

    🦊   -   Vererbung
    🦊   -   Hygrometer ist eine spezialisierte Unterklasse von Messgerät
    🦊   -   Eltern Kind Beziehung

## 💩 Frage 6 

    🦊   -   diese abstrakte Methode ist public und 
    🦊   -   muss von der unterklasse implementiert werden

## 💩 Frage 7

    🦊   -   Da es sich um spezialisierte Klassen handelt, besitzen diese 
                unterschiedliche Eigenschaften und um diese zu unterscheiden sind diese aufgelistet
    🦊   -   Zudem müssen in den Unterklassen alle Eigenschaften und Methoden der Elternklassen enthalten sein
    🦊   -   da diese vererbt sind und die kind klassen keine Eigenschaften ablehnen können   

## 💩 Frage 8 

    🦊   -   Der Protected Zustand #
    🦊   -   Messwerte stellen einen Moment-Zustand dar
    🦊   -   Und sollten nicht Überschrieben werden
    🦊   -   damit statistiken und Grafiken implementiert werden können
    -   

## 💩 Frage 9

    🦊   -   Die Klassen Hygrometer und Thermometer erben die Eigenschaften vom 
                Elternteil Messgerät
    🦊   -   diese erfassen Messwerte und übernehmen die abstracte Methode ErfasseMesswert()
    🦊   -   die Klasse Hygrometer erzeugt eine spezialisierte Methode hygrometer() 
    🦊   -   die Klasse Thermometer erzeugt eine spezialisierte Methode thermometer() 
    🦊   -   diese Sub-Methoden erben von der abstracten messwert() methode
            -   gekennzeichnet mit ":" 
        