﻿namespace _19_3_Interfaces;

//REVIEW - class Program
class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine(@"

            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%###%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%##*******##%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@%#***************##%%@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@###*******************###%@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@%%#****************************##%%@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@%%##**********************************##%%@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@###***************************************#*#%@@@@@@@@@@@@@
            @@@@@@@@@@%%##******************+++++++++++******************##%%@@@@@@@@@
            @@@@@@@%##*****************+=-----------------=+*****************###%@@@@@
            @@@@@%##****************=-------------------------=+****************##%@@@
            @@@@##***************+-------------------------------+************####%@@@
            @@@@***************+-----------------------------------+*******#######%@@@
            @@@@**************=------------=+*********+==-----------=***##########%@@@
            @@@@*************-----------+*****************+----------+##%#########%@@@
            @@@@************----------+*********************+----=+*##############%@@@
            @@@@***********----------*************************+*######%+++##*++###%@@@
            @@@@**********+---------**********************#############--=##---###%@@@
            @@@@**********---------+******************####%%#######*===---==---=##%@@@
            @@@@**********---------****************####%###########*==---==---++##%@@@
            @@@@**********---------************####%#################*--+##--=####%@@@
            @@@@**********=--------+*****###########################+--=**---***##%@@@
            @@@@***********---------+########################%######+--*#*--+#####%@@@
            @@@@***********=---------+#######################*-=*#################%@@@
            @@@@************=---------=*###################*=-----=+*#############%@@@
            @@@@***********##+-----------+*##############+=----------+############%@@@
            @@@@*******#######*-------------=++*****++=-------------+#############%@@@
            @@@@****############+---------------------------------+###############%@@@
            @@@@%###%#%###########+=----------------------------+##%#############%%@@@
            @@@@@%%%#################+=---------------------=+*###############%%%%@@@@@
            @@@@@@@@@%%%%###############*++=-----------==+*###############%%%%@@@@@@@@
            @@@@@@@@@@@@@%%%###############%%#########################%%%%@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@%%%%###################################%%%%@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@%%#############################%#%%%@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@%%#%#######################%%%%@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@%%%%#################%@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%#########%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%####%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            

            **************************************************************************

                Interfaces - Zeichenanwendung 

                Sie erstellen eine Zeichenanwendung und haben derzeit
                nur 1 Werkzeug - einen Bleistift.
                Sie möchten Pinsel und Sprühdose zum
                Zeichenwerkzeug hinzufügen.

                Das Ihnen gegebene Programm deklariert
                eine IDraw Schnittstelle mit der StartDraw() Methode
                und die Klasse Draw,
                
                die das Zeichnen mit dem Bleistift durch Implementierung
                der IDraw-Schnittstelle durchführt. Es gibt Using pencil aus.

                Vervollständigen Sie die gegebenen Brush und Spray Klassen durch

                - Vererbung von der Klasse Draw
                - Implementierung der StartDraw() Methode für jedes Werkzeug,
                   um auszugeben

                Using brush für Brush, oder
                Using spray für Spray.

                Die Draw-Objekte und ihre Methodenaufrufe
                werden in Main() bereitgestellt.

                Tipp: das Keyword override nicht vergessen

            **************************************************************************");


            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();
    }
}


//REVIEW - Interface Draw
public interface I_Draw
{
    void StartDraw();                   //SECTION - defined with the method StartDraw()
}

//REVIEW - SubClass   Draw
class Draw : I_Draw
{
    public virtual void StartDraw()
    {
        System.Console.WriteLine("Using pencil");
    }
}

//REVIEW - class Spray
class Spray : Draw
{
    public override void StartDraw()
    {
        System.Console.WriteLine("Using Spray");
    }
}


//REVIEW - class Brush
class Brush : Draw
{
    public override void StartDraw()
    {
        System.Console.WriteLine("Using Brush");
    }
}

