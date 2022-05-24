# ChalkDotNET
A fluent way to style text for output in System.Console.

This library mimics the [chalk](https://www.npmjs.com/package/chalk) library for node.js but for .NET.

### Examples:
```csharp
Console.WriteLine(Chalk.Yellow("My") + " " + Chalk.Red().BgWhite("name") + " " + Chalk.Blue("is") + " " + Chalk.Underline("Bob."));

ChalkedStringBuilder sb = new ChalkedStringBuilder();
sb.Append("ChalkedStringBuilder");
sb.AppendLine(Chalk.Green(" works"));
sb.Append(Chalk.BgGreen("too!"));
Console.WriteLine(sb);
```

### Features:
- Expressive API
- No dependencies
- ~~256/Truecolor color support~~ (may be coming soon)
- ~~Auto-detects color support~~
- Clean and focused

The library was tested against Windows Command Prompt (cmd.exe). For PowerShell, see [this Stack Overflow answer](https://stackoverflow.com/a/51681675).