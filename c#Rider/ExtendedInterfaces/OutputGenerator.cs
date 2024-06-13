namespace ExtendedInterfaces;

class OutputGenerator : ICanOutput
{
	// Implementiert ICanDraw.Draw
	public void Draw()
	{

	}

	// Implementiert ICanDraw.Print
	public void Print(string text)
	{

	}

	// Implementiert ICanOutput.MakeSound
	public void MakeSound()
	{

	}

	public void MakeNoise()
	{
		throw new NotImplementedException();
	}
}
