## install


- Öffnen Sie PowerShell und stellen Sie sicher, dass Sie .NET Core installiert haben. Wenn Sie .NET Core nicht installiert haben, können Sie es von der offiziellen Microsoft .NET Core Download-Seite herunterladen und installieren: https://dotnet.microsoft.com/download
- Sobald Sie .NET Core installiert haben, können Sie das NUnit 3 Test Runner-Paket mit dem Befehl dotnet installieren.
- Führen Sie den folgenden Befehl aus, um den NUnit 3 Test Runner zu installieren:

```powershell
dotnet tool install --global dotnet-nunit3-testrunner
```
- Mit diesem Befehl wird der NUnit 3 Test Runner als globales .NET Core-Tool installiert.
Nachdem die Installation abgeschlossen ist, können Sie die Installation mit dem folgenden Befehl überprüfen:


```powershell
dotnet nunit3-testrunner --version
```
Dieser Befehl sollte die Versionsnummer von NUnit 3 Test Runner anzeigen.

Um NUnit zum Ausführen von Tests zu verwenden, navigieren Sie zu dem Verzeichnis, das Ihr NUnit-Testprojekt oder Ihre Testanordnung enthält, und führen Sie den folgenden Befehl aus:

```powershell
dotnet nunit3-testrunner <test-assembly-name.dll>
```
Das war's! Sie haben NUnit auf PowerShell installiert und sind bereit, mit dem Schreiben und Ausführen von Unit-Tests zu beginnen.

Hinweis: Sie können auch den Chocolatey-Paketmanager verwenden, um NUnit unter Windows zu installieren. Um NUnit mit Chocolatey zu installieren, führen Sie den folgenden Befehl aus:


```powershell
choco install nunit
```



```powershell
dotnet new sln
```

Der Befehl dotnet new sln ist ein Befehl der Befehlszeilenschnittstelle (CLI), der im .NET-Ökosystem zur Erstellung einer neuen Solution verwendet wird. Eine Solution in .NET ist ein Container auf hoher Ebene, der ein oder mehrere Projekte enthalten kann. Dieser Befehl ist Teil der .NET Core CLI, einer plattformübergreifenden Toolchain für die Entwicklung von .NET-Anwendungen.

Hier finden Sie die Aufschlüsselung des Befehls und seiner Funktionen:
Heres a breakdown of the command and what it does:

dotnet: Dies ist die command-line interface für .NET Core. Sie bietet eine Reihe von Befehlen zum Erstellen, Erstellen, Ausführen und Veröffentlichen von .NET Core-Anwendungen.

- new: Dieser Befehl wird verwendet, um ein neues .NET-Projekt oder eine neue Datei zu erstellen. 
- sln: Dies ist der Name der Elementvorlage für die Erstellung einer Projektmappendatei.
- Wenn Sie den Befehl dotnet new sln ausführen, wird eine neue leere Projektmappendatei im aktuellen Verzeichnis erstellt. Lösungsdateien haben die Erweiterung .sln, und sie können mit Visual Studio oder einem beliebigen Texteditor geöffnet und verwaltet werden.

Zusammenfassend lässt sich sagen, dass der Befehl dotnet new sln verwendet wird, um eine neue Projektmappe in .NET zu erstellen, die ein High-Level-Container zum Organisieren und Erstellen von Projekten ist.
