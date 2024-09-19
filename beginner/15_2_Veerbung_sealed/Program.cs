using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            string accNumber;
            do  {
                Console.Write(@"                              Please enter your IBAN: ");
                  accNumber = Console.ReadLine();
                } while (!sIsValid_IBAN(accNumber));
           

            static bool sIsValid_IBAN(string iban)
            {
                // IBAN pattern: 2 letters (country code) followed by 2 digits, then up to 30 alphanumeric characters
                string pattern = @"^[A-Z]{2}[0-9]{2}[A-Z0-9]{1,30}$";
                return Regex.IsMatch(iban, pattern);
                // IBAN pattern: 4 groups of 4 digits, separated by spaces
                string pattern = @"^(\d{4} ){3}\d{4}$";
                return Regex.IsMatch(iban, pattern);
            }

            double balance;
            do  {
                Console.Write(@"                              Please enter your Balance: ");
                balance = Console.Read();
                } while (!bIsValid_Balance(balance));

            static bool bIsValid_Balance(string balance)
            {
                // Balance Pattern:
                string pattern = @"^\d{1,4}\.\d{2}$";
                return Regex.IsMatch(balance, pattern);
            }





            User user = new User(accNumber, balance);

            user.ShowDetails();
        }

}

class Account
{
    //FIXME - private double Balance { get; set; } setzen wir in protected damit wir in der abgeleiteten 
            protected double Balance { get; set; }

    //FIXME -  Constructors should be lightweight and not perform complex operations or I/O operations
    // public Account() //Klassenkonstruktor
    //  {
    //    Console.Write("Enter initial balance: ");
    //    Balance = Convert.ToDouble(Console.ReadLine() ?? "0");
    //  }
}

class User : Account
{
    public string AccNumber { get; set; }

    //complete the constructor
    public User(string accNumber, double balance)
    {
        this.Balance = balance;                     //REVIEW - init Property: "Balance" und übergeben es an den Konstruktor
        this.AccNumber = accNumber;                 //REVIEW - init Property: "AccNumber" und übergeben es an den Konstruktor
    }
    public void ShowDetails()
    {
            Console.WriteLine("Account N: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
    }
}
