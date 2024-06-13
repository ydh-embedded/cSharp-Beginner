namespace ExtendedInterfaces;

// Ein Interface kann von anderen Interfaces erben.
// Man führt dadurch kleinere Schnittstellen zu größeren zusammen.
interface ICanOutput : ICanDraw, ICanPrint, ICanMakeSound
{
}

interface IAudible
{
	void MakeSound();
	bool MakeNoise();
}

class C : ICanMakeSound, ICanOutput, IAudible
{
	// Implementiert ICanDraw.Draw
	public void Draw()
	{
		throw new NotImplementedException();
	}

	// Implementiert ICanMakeSound.MakeNoise
	public void MakeNoise()
	{
		throw new NotImplementedException();
	}

	// IAudible.MakeNoise kollidiert mit ICanMakeSound.MakeNoise.
	// Der Konflikt lässt sich durch explizite Implementierung
	// des Members IAudible.MakeNoise lösen.
	// Achtung: Bei einer expliziten Implementierung MUSS der Zugriffsmodifizierer
	// public weggelassen werden.
	bool IAudible.MakeNoise()
	{
		return true;
	}

	// Implementiert ICanMakeSound.MakeSound
	public void MakeSound()
	{
		throw new NotImplementedException();
	}

	// Implementiert ICanPrint.Print
	public void Print(string text)
	{
		throw new NotImplementedException();
	}

	static void Main(string[] args)
	{
		C c = new();
		c.MakeNoise(); // IMakeSound.MakeNoise
		(c as IAudible).MakeNoise(); // IAudible.MakeNoise

	}
}
