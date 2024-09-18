
**The problem:** The error message indicates that the `msbuild` command is not recognized as a valid command, function, script file, or executable program. This is likely because the `msbuild` executable is not in your system's PATH environment variable.

**The solution:** To fix this issue, you need to specify the full path to the `msbuild` executable. The location of `msbuild` varies depending on your .NET installation, but here are a few common locations:

- For .NET Framework: `C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe`
- For .NET Core: `C:\Program Files\dotnet\sdk\<SDK_VERSION>\MSBuild\Current\Bin\msbuild.exe`

Replace `<SDK_VERSION>` with the actual version of the .NET Core SDK you have installed.

**Example:** Assuming you have .NET Core 3.1 installed, the full path to `msbuild` would be:

```bash
	file:///C:/Program%20Files/dotnet/sdk/3.1.100/MSBuild/Current/Bin/msbuild.exe
```

So, you would run the command like this:


```bash

	(base) PS C:\working-directory\cSharp-Beginner\beginner\15_2_Veerbung_sealed> "C:\Program Files\dotnet\sdk\3.1.100\MSBuild\Current\Bin\msbuild.exe" YourProject.csproj /t:Rebuild /logger:MSBuildLogger,YourLoggerAssembly > Bug_Errors.md
```


Make sure to replace `YourProject.csproj` with the actual path to your project file.

If you're still having issues, you can try running the command from the Visual Studio Developer Command Prompt, which should have the `msbuild` executable in its PATH.

________

To export the C# compiler failure in a table style to a separate file "Bug_Errors", you can use the `msbuild` command with the `/fileLogger` option. Here's an example:

```bash
	msbuild YourProject.csproj /t:Rebuild /fileLoggerParameters:LogFile=Bug_Errors.txt;Verbosity=Diagnostic;Encoding=UTF-8
```

This will generate a file named "Bug_Errors.txt" that contains only the error messages in a plain text format.

If you want to format the output as a Markdown table, you can use a tool like `msbuild-logger`:

```bash
	msbuild YourProject.csproj
	/t:Rebuild /logger:MSBuildLogger,YourLoggerAssembly > Bug_Errors.md
```

You'll need to create a custom logger assembly that formats the output as a Markdown table. Here's an example implementation:

```cs

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

public class MarkdownLogger : Logger
{
    public override void ErrorOccurred(BuildEventFileInfo file, string message, string helpKeyword, string senderName)
    {
        Console.WriteLine($"| {file.FileName} | {message} | {file.LineNumber} |");
    }
}
```

This will generate a file named "Bug_Errors.md" that contains the compiler errors in a Markdown table format.

Note that these examples assume that you are using the .NET Framework or .NET Core on a Windows system. If you are using a different platform or framework, you may need to use a different approach.