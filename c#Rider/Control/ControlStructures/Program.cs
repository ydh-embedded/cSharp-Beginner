namespace ControlStructures;

internal class Program
{
	static void Main(string[] args)
	{
		try
		{
			TryCatchFinally();
		}
		catch (Exception e)
		{
			Console.WriteLine("Eine Ausnahme ist aufgetreten. Beende das Programm");
			Console.WriteLine("Nachricht: " + e.Message);
		}
	}

	static void IfStatement()
	{
		var rng = new Random(); // Random Number Generator
		int age = rng.Next(5, 25); // Zufallszahl im Bereich 5 bis 25 - 1

		// Die Operatoren sind identisch zu denen bei Java: <,>,>=,<=,&&,||,!,!=
		if (age >= 18)
		{
			Console.WriteLine($"Mit {age} Jahren bist du volljährig!");
		}
		else if (age < 13)
		{
			Console.WriteLine($"Mit {age} Jahren bist du noch nicht mal ein Teenager!");
		}
		else
		{
			Console.WriteLine($"Mit {age} Jahren musst du noch {18 - age} Jahre warten, bis du volljährig wirst!");
		}

		//if (age >= 13 && age <= 19)
		// Hier verwenden wir sogenannte Patterns (relational und logical Patterns).
		if (age is >= 13 and <= 19)
		{
			Console.WriteLine("Du bist ein Teenager!");
		}
		else
		{
			Console.WriteLine("Du bist KEIN Teenager!");
		}

	}

	static void WhileLoop()
	{
		int numberOfSixes = 0;
		int totalRolls = 0;
		Random rng = new(); // Kurzform für Random rng = new Random();
		while (numberOfSixes < 10)
		{
			int value = rng.Next(1, 6 + 1); // Zufallszahl im Bereich 1 bis 6.
			totalRolls++;
			if (value == 6)
			{
				numberOfSixes++;
			}
		}
		Console.WriteLine($"Nach {totalRolls} Würfen, haben wir {numberOfSixes} mal die 6 gewürfelt.");
	}

	static void DoWhileLoop()
	{
		Random rng = new();
		HashSet<int> lottoNumbers = new();
		do
		{
			int number = rng.Next(1, 49 + 1);
			lottoNumbers.Add(number);
		}
		while (lottoNumbers.Count < 7);

		List<int> sortedLottoNumbers = lottoNumbers.ToList();
		sortedLottoNumbers.Sort();
		foreach (int number in sortedLottoNumbers)
		{
			Console.Write($"{number:D2} ");
		}
		Console.WriteLine();
	}

	static void ForLoop()
	{
		int[] primes = [2, 3, 5, 7, 11, 13, 17];
		for (int i = 0; i < primes.Length; i++)
		{
			Console.Write($"{primes[i]:D2} ");
		}
		Console.WriteLine();

		Console.WriteLine(primes[primes.Length - 1]);
		Console.WriteLine(primes[^1]); // letztes Element
		Console.WriteLine(primes[^2]); // vorletztes Element
		Index lastElement = ^1;
		Console.WriteLine(primes[lastElement]);
	}

	static void ForeachLoop()
	{
		foreach (char c in "Hello World")
		{
			bool isVowel = "aeiouAEIOU".Contains(c);
			if (!isVowel)
			{
				Console.Write($"{c} ");
			}
		}
		Console.WriteLine();

		string[] names = ["alice", "bob", "charlie", "damian"];
		foreach (string n in names)
		{
			Console.WriteLine(n.ToUpper());
		}
	}

	static void TryCatchFinally()
	{
		try
		{
			// Hier werden Anweisungen auf Exceptions überwacht.
			Console.WriteLine("Versuche durch Null zu dividieren");
			int zero = 0;
			int result = 5 / zero;
			Console.WriteLine($"Ergebnis ist {result}");
		}
		catch (DivideByZeroException e)
		{
			Console.WriteLine("Division durch Null ist mathematisch unzulässig.");
			Console.WriteLine("🤢" + e.StackTrace);
			throw new Exception("Berechnungsfehler", e); // Weiterreichen zum Aufrufer
		}
		finally
		{
			// Alle Anweisungen die hier stehen, werden immer ausgeführt.
			// Unabhängig davon, ob eine Exception ausgelöst wurde.
			Console.WriteLine("Ressourcen freigeben");
		}

		Console.WriteLine("Methode ist abgearbeitet");

	}

	static void SwitchStatement()
	{

	}

	static void SwitchExpression()
	{

	}
}
