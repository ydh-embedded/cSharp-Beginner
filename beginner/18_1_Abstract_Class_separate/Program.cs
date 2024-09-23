namespace _18_1_Abstract_Class_separate;


//REVIEW - class Program
public abstract class Program
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

                Abstrakte Klassen - Draw Methode

                Wie im vorherigen Beispiel beschrieben,
                wird Polymorphie verwendet,
                wenn Sie verschiedene abgeleitete Klassen mit
                der gleichen Methode haben,
                die in jeder Klasse unterschiedliche Implementierungen hat.
                Dieses Verhalten wird durch virtuelle Methoden erreicht,
                die in den abgeleiteten Klassen überschrieben werden.

                In einigen Situationen besteht keine sinnvolle Notwendigkeit dafür,
                dass die virtuelle Methode eine separate Definition in der Basisklasse hat.

                Diese Methoden werden mit dem Schlüsselwort abstract definiert und geben an,
                dass die abgeleiteten Klassen diese Methode selbst definieren müssen.

                Sie können keine Objekte einer Klasse erstellen,
                die eine abstrakte Methode enthält,
                weshalb die Klasse selbst abstrakt sein sollte.

                Wir könnten eine abstrakte Methode in der Klasse Shape verwenden: 
                abstract class Shape {  public abstract void Draw();  }

                Wie Sie sehen können, ist die Draw-Methode abstrakt und
                hat daher keinen Körper. Sie benötigen nicht einmal die geschweiften Klammern;
                beenden Sie die Aussage einfach mit einem Semikolon.

                
                Wichtig:
                
                Die Shape-Klasse selbst muss als abstrakt deklariert werden,
                weil sie eine abstrakte Methode enthält.
                Abstrakte Methodendeklarationen sind nur in abstrakten Klassen zulässig.

                Info:

                Denken Sie daran,
                dass abstrakte Methodendeklarationen nur in abstrakten Klassen zulässig sind.
                Mitglieder, die als abstrakt gekennzeichnet sind oder
                in einer abstrakten Klasse enthalten sind,
                müssen von Klassen implementiert werden,
                die von der abstrakten Klasse abgeleitet sind.
                Eine abstrakte Klasse kann mehrere abstrakte Mitglieder haben.



            **************************************************************************");




    }
}



