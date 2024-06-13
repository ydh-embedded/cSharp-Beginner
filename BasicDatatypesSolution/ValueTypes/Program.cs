// Füge alle Typdefinitionen in dieser Datei
// zum Namespace ValueTypes hinzu.
using System.Collections;

namespace ValueTypes;

// Ein als internal deklarierter Datentyp ist nur innerhalb der
// Assembly sichtbar. Andere Assemblies können diesen Typ also nicht importieren.
// Hinweis: Soll der Datentyp auch von anderen Assemblies genutzt werden können,
// so muss der Datentyp als public deklariert sein.
public class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
		int age = 18; // Vorzeichenbehafteter 32-Bit Integer
		uint unsignedInteger = 12; // Vorzeichnloser 32 Bit Integer

		byte data = 0b1000_1000; // Vorzeichenloses Byte (Basis 2) (8 Bit)
		sbyte signedByte = -5; // Vorzeichenbehafteter 8 Bit Integer

		data = 0xff; // Hexadezimalzahl (Basis 16)
		data = 0100; // Achtung: Das ist eine Dezimalzahl (Basis 10)
		Console.WriteLine("Data: " + data); // Ausgabe als Dezimalzahl (Basis 10)
		
		short dataWord = 1010; // Vorzeichenbehafteter 16 Bit Integer
		ushort unsignedShort = 1234; // Vorzeichenloser 16 Bit Integer

		long bigNumber = 0xcafebabe; // Vorzeichenbehafteter 64 Bit Integer
		ulong unsignedBigNumber = (ulong)1e8; // Vorzeichenloser 64 Bit Integer

		decimal ratio = 20.15m; // Gleitkommazahl, die intern Dezimalsystem verwendet (128 Bits)
		double average = 4.267; // Gleitkommazahl, die intern Binärsystem verwendet (64 Bits)
		float proportion = 3.15f; // Gleitkommzahl, die intern Binärsystem verwendet (32 Bits)

		bool isCorrect = true; // Wahrheitswert
		char letter = 'a'; // Speichert ein Zeichen (2 Byte)

		
				
	}
}
