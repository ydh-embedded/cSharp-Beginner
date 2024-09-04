
using System;

namespace SwitchUndCase
{
	class Pro
	{
		static void Main (string [] args){

			int age = 19;
			switch (age)
			{
				case 10:
					Console.WriteLine("Zu Jung zum Feiern");
					break;

				case 15:
					Console.WriteLine("Zu Jung zum Feiern");
					break;


				case 20:
					Console.WriteLine("Du darfst in den Club");
					break;

				default; // wenn die Bedingung nicht übereinstimmt wird gebreakt
					break;
			}
		}
	}
}