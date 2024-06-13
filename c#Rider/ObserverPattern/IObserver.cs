namespace ObserverPattern;

// Diese Schnittstelle wird von Klassen implementiert,
// deren Objekte andere Objekte beobachten wollen.
interface IObserver
{
	// Diese Methode wird vom Observable Objekt aufgerufen,
	// wenn sich der Zustand des Observable-Objekts ändert.
	void Update(IObservable observable);
}
