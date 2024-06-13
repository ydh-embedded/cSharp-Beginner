# install

Open PowerShell and make sure you have .NET Core installed. If you don't have .NET Core installed, you can download and install it from the official Microsoft .NET Core download page: https://dotnet.microsoft.com/download
Once you have .NET Core installed, you can install the NUnit 3 Test Runner package using the dotnet command. Run the following command to install the NUnit 3 Test Runner:

```powershell
dotnet tool install --global dotnet-nunit3-testrunner
```
This command installs the NUnit 3 Test Runner as a global .NET Core tool.

After the installation is complete, you can verify the installation by running the following command:

```powershell
dotnet nunit3-testrunner --version
```
This command should display the version number of the NUnit 3 Test Runner.

To use NUnit to run tests, navigate to the directory containing your NUnit test project or test assembly, and run the following command:

```powershell
dotnet nunit3-testrunner <test-assembly-name.dll>
```
That's it! You have installed NUnit on PowerShell and are ready to start writing and running unit tests.

Note: You can also use the Chocolatey package manager to install NUnit on Windows. To install NUnit using Chocolatey, run the following command:

````powershell
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
