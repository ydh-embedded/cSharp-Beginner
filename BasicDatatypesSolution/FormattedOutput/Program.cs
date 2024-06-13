namespace FormattedOutput;

internal class Program
{
	static void Main(string[] args)
	{
		int age = 21;
		double average = 23.4567;
		string name = "Max Mustermann";

		// String-Interpolation erlaubt das Einfügen von Ausdrücken
		// in Zeichenketten. Um String-Interpolation zu nutzen, muss
		// die Zeichenkette mit $ beginnen.
		Console.WriteLine($"Klammer: {{ }} Alter: {age} Durchschnitt: {average:N2} Name: {name.ToUpper()}");
		Console.WriteLine("Klammer: {{ }} Alter: {0} Durchschnitt: {1:N2} Name: {2}", age, average, name.ToUpper());
		Console.WriteLine(string.Format("Alter: {0} Durchschnitt: {1:N2} Name: {2}", age, average, name.ToUpper()));
	}
}
