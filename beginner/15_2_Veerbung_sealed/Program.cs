using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Threading;
using System.Threading.Tasks;




namespace _15_2_Veerbung_sealed;

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

                Inheritance - protected

                Das Ihnen gegebene Programm nimmt eine Kontonummer und
                ihren Saldo als Eingabe.Es definiert die Account Klasse
                mit 1 Mitglied balance und leitet die User-Klasse davon
                ab mit 1 zusätzlichem Mitglied - der Kontonummer,
                erstellt dann ein User-Objekt und versucht,
                den Saldo und die Kontonummer darin zu speichern,
                und zeigt die Details an. Aber etwas stimmt nicht.
                
                Korrigieren Sie das Programm so,
                dass es den User()-Konstruktor vervollständigt,
                der die Parameter den entsprechenden Mitgliedern
                der User-Klasse zuweisen sollte.

                Überprüfen Sie auch den Zugriffsmodifizierer
                des balance-Mitglieds der Account-Klasse.

                Beispiel-Eingabe:

                0056 1521 1236 4561
                ReGeX pattern matches:
                            
                (\d{4} ){3} exactly 3 groups of 4 digits, separated by spaces
                \d{4} the final group of 4 digits
                
                1488.36
                ReGeX pattern matches:

                \d{1,4} between 1 and 4 digits
                \. the decimal point
                \d{2} exactly 2 digits


                Beispiel-Ausgabe:

                Konto Nr: 0056 1521 1236 4561
                Saldo: 1488.36


            **************************************************************************");

            string sAccNumber;
            do  {
                Console.Write(@"                              Please enter your IBAN: ");
                  sAccNumber = Console.ReadLine();
                } while (!bIsValid_IBAN(sAccNumber));
            

            static bool bIsValid_IBAN(string iban)
            {
                // IBAN pattern: 4 groups of 4 digits, separated by spaces
                string pattern = @"^(\d{4} ){3}\d{4}$";
                return Regex.IsMatch(iban, pattern);
            }

            string sInput_Balance;
            do
            {
                Console.Write(@"                              Please enter your Balance: ");
                sInput_Balance = Console.ReadLine();
            } while (!bIsValid_Balance(sInput_Balance));

            User user = new User(sAccNumber, double.Parse(sInput_Balance));
            user.ShowDetails();

            static bool bIsValid_Balance(string sbalance)
            {
                // Balance Pattern:
                string pattern = @"^\d{1,4}\.\d{2}$";
                return Regex.IsMatch(sbalance, pattern);
            }


            User user = new User(sAccNumber, dBalance);

            user.ShowDetails();
        }

}

class Account
{
    protected double Balance { get; set; }
}

class User : Account
{
    public string sAccNumber { get; set; }
    public string sInput_Balance { get; set;}

    //complete the constructor
    public User(string saccnumber, double dbalance)
    {
        this.Balance = dbalance;                              //REVIEW - init Property: "sAccNumber" und übergeben es an den Konstruktor
        this.sAccNumber = saccnumber;                        //REVIEW - init Property: "Balance" und übergeben es an den Konstruktor
    }
    public void ShowDetails()
    {
            Console.WriteLine("Account N: " + sAccNumber);
            Console.WriteLine("Balance: " + Balance);
    }
}
