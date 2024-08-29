using System;

namespace IfStatement{

	class Pro {
		static string username;			// existieren nur während der Pro Laufzeit
		static string password;			// existieren nur während der Pro Laufzeit

		static void Main(string[] args){
			Console.WriteLine("-------------------------------------------------------------------------------");
			Console.WriteLine("                             Wir schreiben den ersten Login Code");
			Console.WriteLine("-------------------------------------------------------------------------------");

			Register();
			Login();
			Console.ReadKey();
		}


		// Register Item
		public static static void Register(){

			Console.WriteLine("Trage hier deinen Username ein");
			username = Console.ReadLine(); // Zeile einlesen
			Console.WriteLine("Trage hier dein Passwort ein");
			password = Console.ReadLine(); // Zeile einlesen
			Console.WriteLine("Registrierung erfolgreich");
		}

		public static void Login(){

			Console.WriteLine("Trage hier Benutzername ein");
			if(username == Console.ReadLine()){

				if(password == Console.ReadLine()){
						Console.WriteLine("Du bist jetzt eingeloggt");
				}
				else
				{
					Console.WriteLine("Das hat nicht geklappt");
				}
			}
			else
			{
				Console.WriteLine("Benutzername nicht gefunden");
			}

		}
	}
}