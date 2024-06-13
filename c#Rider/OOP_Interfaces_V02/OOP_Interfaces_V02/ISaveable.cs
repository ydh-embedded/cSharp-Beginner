namespace Interfaces;

interface ISaveable
{
	string ID { get; }
	void Save();
}