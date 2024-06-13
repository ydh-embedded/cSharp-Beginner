namespace ExtendedInterfaces.Conflicting;

interface IA
{
	void M()
	{
		Console.WriteLine("IA.M");
	}
}

interface IB
{
	void M()
	{
		Console.WriteLine("IB.M");
	}
}

class C : IA, IB
{

}

class D : IA, IB
{
	public void M()
	{
		Console.WriteLine("D.M");
	}
}

internal class ConflictingDefaultImplementations
{
	static void Main(string[] args)
	{
		C c = new();
		(c as IA).M(); // IA.M
		(c as IB).M(); // IB.M

		D d = new();
		d.M(); // D.M
		(d as IA).M(); // D.M
		(d as IB).M(); // D.M
	}
}
