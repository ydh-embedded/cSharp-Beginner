namespace ObserverPattern;

// Diese Schnittstelle wird von Klassen implementiert,
// deren Objekte beobachtbar sein sollen.
interface IObservable
{
	void AddObserver(IObserver observer); // Registrieren
	void RemoveObserver(IObserver observer); // Abmelden
}
