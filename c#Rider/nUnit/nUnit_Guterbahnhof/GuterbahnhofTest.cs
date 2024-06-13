using NUnit.Framework;
using nUnit_Guterbahnhof;
using NUnit.Framework.Legacy;
namespace nUnit_Guterbahnhof;

[TestFixture]
public class GuterbahnhofTest
{
	[Test(Description = "Der erste Waggon setzt das Ziel des Zuges")]
	public void AddWaggon_FirstWaggonSetsTargetForTrain()
	{
		const string ziel = "Erfurt";

		Gueterzug vZug = new();
		Gueterwaggon vWaggon = new(ziel, 1);
		vZug.AddWaggon(vWaggon);
		// Der Zug sollte dasselbe Ziel wie der Waggon haben.
		ClassicAssert.AreEqual(expected: vWaggon.GetZiel(), actual: vZug.GetZiel());
	}

	[Test(Description = "Throws exception when waggon has different target")]
	public void AddWaggon_ThrowsExceptionWhenWaggonHasDifferentTarget()
	{
		Gueterzug vZug = new();
		Gueterwaggon vWaggonA = new("Erfurt" , 1);
		Gueterwaggon vWaggonB = new("Leipzig", 2);
		vZug.AddWaggon(vWaggonA);

		ClassicAssert.Throws(typeof(InvalidOperationException), () => vZug.AddWaggon(vWaggonB));
	}
 
	[SetUp]
	public void PrepareTest()
	{
		// Führe Vorbereitungen für den nächsten auszuführenden Test durch.
		Console.WriteLine("Vor dem Test");
	}

	[TearDown]
	public void FinishTest()
	{
		// Führe Aufräumarbeiten nach Ausführung des Tests durch
		Console.WriteLine("Nach dem Test");
	}
}

public class Gueterwaggon : Waggon
{
	public Gueterwaggon(string Erfurt, int i) : base("Jena")
	{
		throw new NotImplementedException();
	}
}